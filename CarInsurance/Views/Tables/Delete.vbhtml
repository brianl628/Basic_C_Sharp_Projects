﻿@ModelType CarInsurance.Table
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Table</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FirstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmailAddress)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmailAddress)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DateOfBirth)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DateOfBirth)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CarYear)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CarYear)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CarMake)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CarMake)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CarModel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CarModel)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DUI)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DUI)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SpeedingTickets)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SpeedingTickets)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CoverageType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CoverageType)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Quote)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Quote)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
