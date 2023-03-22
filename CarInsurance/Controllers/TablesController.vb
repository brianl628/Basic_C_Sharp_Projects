Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CarInsurance

Namespace Controllers
    Public Class TablesController
        Inherits System.Web.Mvc.Controller

        Private db As New Models

        ' GET: Tables
        Function Index() As ActionResult
            Return View(db.Tables.ToList())
        End Function

        ' GET: Tables/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Tables.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' GET: Tables/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Tables/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")> ByVal table As Table) As ActionResult
            If ModelState.IsValid Then
                db.Tables.Add(table)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(table)
        End Function

        ' GET: Tables/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Tables.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' POST: Tables/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")> ByVal table As Table) As ActionResult
            If ModelState.IsValid Then
                db.Entry(table).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(table)
        End Function

        ' GET: Tables/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Tables.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' POST: Tables/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim table As Table = db.Tables.Find(id)
            db.Tables.Remove(table)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Function Admin() As ActionResult
            Return View(db.Tables.ToList())
        End Function

        Public Function CalculateQuota(ByVal Tables As Table) As Decimal
            Dim baseCost As Decimal = 50
            Dim today = DateTime.Today
            Dim age As Integer = today.Year - Tables.DateOfBirth.Year

            If age <= 18 Then
            ElseIf age >= 19 AndAlso age <= 25 Then
                baseCost = Decimal.Add(baseCost, 50)
            Else
                baseCost = Decimal.Add(baseCost, 25)
            End If
            If Tables.CarYear < 2000 OrElse Tables.CarYear > 2015 Then
                baseCost = Decimal.Add(baseCost, 25)
            End If
            If Tables.CarMake = "Porsche" Then
                baseCost = Decimal.Add(baseCost, 25)
            End If
            If Tables.CarModel = "911 Carrera" Then
                baseCost = Decimal.Add(baseCost, 25)
            End If
            If Tables.SpeedingTickets > 0 Then
                Dim feeTicket As Decimal = Tables.SpeedingTickets * 10
                baseCost = Decimal.Add(baseCost, feeTicket)
            End If
            If Tables.DUI = True Then
                Dim upcharge As Decimal = baseCost / 4
                baseCost = Decimal.Add(baseCost, upcharge)
            End If
            If Tables.CoverageType = True Then
                Dim coverFee As Decimal = baseCost / 2
                baseCost = Decimal.Add(baseCost, coverFee)
            End If
            Return baseCost


        End Function

    End Class
End Namespace
