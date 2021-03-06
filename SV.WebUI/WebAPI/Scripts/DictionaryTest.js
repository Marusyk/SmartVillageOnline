﻿GetDictionary();
function GetAllEntities() {
	jQuery.support.cors = true;
	var dict = $("#sysDictList :selected").text();
	$.ajax({
		url: location.protocol + "//" + location.host + "//api//" + dict,
		type: "GET",
		dataType: "json",
		success: function (data) {
			WriteResponse(data);
		},
		error: function (x, y, z) {
			alert(x + "\n" + y + "\n" + z);
		}
	});
}

function GetEntity() {
	jQuery.support.cors = true;
	var id = $("#txtId").val();
	var dict = $("#sysDictList :selected").text();
	$.ajax({
		url: location.protocol + "//" + location.host + "//api//" + dict + "//" + id,
		type: "GET",
		dataType: "json",
		success: function (data) {
			ShowEntity(data);
		},
		error: function (x, y, z) {
			alert(x + "\n" + y + "\n" + z);
		}
	});
}

function AddEntity() {
	jQuery.support.cors = true;
	var dict = $("#sysDictList :selected").text();
	var entities;
	if (dict === "Region") {
		entities = {
			Name: $("#txtaddName").val(),
			CountryId: $("#linked1").val()
		};
	} else
		if (dict === "District") {
			entities = {
				Name: $("#txtaddName").val(),
				RegionId: $("#linked1").val()
			};
		} else
			if (dict === "City") {
				entities = {
					Name: $("#txtaddName").val(),
					RegionId: $("#linked3").val(),
					DistrictId: $("#linked2").val(),
					CityTypeId: $("#linked1").val()
				};
			} else {
				entities = {
					Name: $("#txtaddName").val()
				};
			}


	$.ajax({
		url: location.protocol + "//" + location.host + "//api//" + dict,
		type: "POST",
		data: JSON.stringify(entities),
		contentType: "application/json;charset=utf-8",
		success: function (data) {
			WriteResponse(data);
		},
		error: function (x, y, z) {
			alert(x + "\n" + y + "\n" + z);
		}
	});
}

function DeleteEntity() {
	jQuery.support.cors = true;
	var dict = $("#sysDictList :selected").text();
	var id = $("#txtdelId").val();
	$.ajax({
		url: location.protocol + "//" + location.host + "//api//" + dict + "/" + id,
		type: "DELETE",
		contentType: "application/json;charset=utf-8",
		success: function (data) {
			WriteResponse(data);
		},
		error: function (x, y, z) {
			alert(x + "\n" + y + "\n" + z);
		}
	});
}


function WriteResponse(entities) {
	var strResult = "<table class='table table-hover'><th>Id</th><th>Name</th><th>LastUpdUs</th><th>LastUpdDt</th>";
	$.each(entities, function (index, entity) {
		strResult += "<tr><td>" + entity.Id + "</td><td> " + entity.Name + "</td><td>" + entity.LastUpdUs + "</td><td>" + entity.LastUpdDt + "</td></tr>";
	});
	strResult += "</table>";
	$("#divResult").html(strResult);
	$("#lblResult").show();
}

function ShowEntity(entity) {
	if (entity != null) {
		var strResult = "<table class='table table-hover'><th>Id</th><th>Name</th><th>LastUpdUs</th><th>LastUpdDt</th>";
		strResult += "<tr><td>" + entity.Id + "</td><td> " + entity.Name + "</td><td>" + entity.LastUpdUs + "</td><td>" + entity.LastUpdDt + "</td></tr>";
		strResult += "</table>";
		$("#divResult").html(strResult);
		$("#lblResult").show();
	}
	else {
		$("#divResult").html("No Results To Display");
	}
}

function GetDictionary() {
	jQuery.support.cors = true;
	$.ajax({
		type: "get",
		url: location.protocol + "//" + location.host + "//api//Dictionary",
		contentType: "application/json;charset=utf-8",
		dataType: "json",
		data: {},
		success: function (result) {
			$.each(result, function (i) {
				$("#sysDictList").append($("<option></option>").val(result[i].Id).html(result[i].Name));
			});
		},
		failure: function () {
			alert("Error");
		}
	});
}

function GetRelatedEntities(name, comp) {
	jQuery.support.cors = true;
	$.ajax({
		type: "get",
		url: location.protocol + "//" + location.host + "//api//" + name,
		contentType: "application/json;charset=utf-8",
		dataType: "json",
		data: {},
		success: function (result) {
			$(comp).empty();
			$.each(result, function (i, result) {
				$(comp).append($("<option></option>").val(result.Id).html(result.Name));
			});
		},
		failure: function () {
			alert("Error");
		}
	});
}

function GetStructur() {
	jQuery.support.cors = true;
	var name = $("#sysDictList :selected").text();
	if (name === "Region" || name === "District") {
		// where exists 1 related objects
		if (name === "Region")
			name = "Country";
		else name = "Region";
		$("#trLinked1").show();
		$("#lblLinked1").text(name + ":");
		GetRelatedEntities(name, "#linked1");
		$("#trLinked2").hide();
		$("#lblLinked2").empty();
		$("#linked2").empty();
		$("#trLinked3").hide();
		$("#lblLinked3").empty();
		$("#linked3").empty();
	}
	else
		if (name === "City") {
			// where exists 3 related objects
			$("#trLinked1").show();
			$("#lblLinked1").text("Type:");
			GetRelatedEntities("CityType", "#linked1");

			$("#trLinked2").show();
			$("#lblLinked2").text("District:");
			GetRelatedEntities("District", "#linked2");

			$("#trLinked3").show();
			$("#lblLinked3").text("Region:");
			GetRelatedEntities("Region", "#linked3");
		}
		else {
			// clear and hide
			$("#trLinked1").hide();
			$("#lblLinked1").empty();
			$("#linked1").empty();
			$("#trLinked2").hide();
			$("#lblLinked2").empty();
			$("#linked2").empty();
			$("#trLinked3").hide();
			$("#lblLinked3").empty();
			$("#linked3").empty();
		}

};