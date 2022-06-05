$(document).ready(function () {
   
});

function OnSuccessAnimals(data) {
    $.ajax({
        url: "https://localhost:44352/Home/AnimalsJson",
        contentType: "application/json",
        method: "GET",
        cache: false,
        success: function (response) {
            var data = "";
            for (var i = 0; i < response.length; i++) {
                data += "////////////////////////////////" + "\n" + "Наименование: " + 
                    response[i].Name + "\n" + "Вес: " + response[i].Weight + "\n" + "Возраст: " + response[i].Age + "\n";
            }
            alert(data);
        },
        error: function (jxqr, error, status) {
            alert("Ошибка " + jxqr.statusText)
        }
    })
}

function OnSuccessAddAnimal(data) {
    alert("Объект успешно добавлен");
}

function OnSuccessRemoveAnimals(data) {
    alert("Список животных очищен!");
}


function OnSuccessBirds(data) {
    $.ajax({
        url: "https://localhost:44352/Home/BirdsJson",
        contentType: "application/json",
        method: "GET",
        cache: false,
        success: function (response) {
            var data = "";
            for (var i = 0; i < response.length; i++) {
                data += "////////////////////////////////" + "\n" + "Наименование: " +
                    response[i].Name + "\n" + "Окраска крыльев: " + response[i].Wings + "\n" + "Птица говорящая: " + response[i].IsTalking + "\n";
            }
            alert(data);
        },
        error: function (jxqr, error, status) {
            alert("Ошибка " + jxqr.statusText)
        }
    })
}

function OnSuccessAddBird(data) {
    alert("Объект успешно добавлен");
}

function OnSuccessRemoveBirds(data) {
    alert("Список птиц очищен!");
}


function OnSuccessMammals(data) {
    $.ajax({
        url: "https://localhost:44352/Home/MammalsJson",
        contentType: "application/json",
        method: "GET",
        cache: false,
        success: function (response) {
            var data = "";
            for (var i = 0; i < response.length; i++) {
                data += "////////////////////////////////" + "\n" + "Наименование: " +
                    response[i].Name + "\n" + "Температура тела:  " + response[i].Temperature + "\n" + "Животное плавает:  " + response[i].IsSwimming + "\n";
            }
            alert(data);
        },
        error: function (jxqr, error, status) {
            alert("Ошибка " + jxqr.statusText)
        }
    })
}

function OnSuccessAddMammal(data) {
    alert("Объект успешно добавлен");
}

function OnSuccessRemoveMammals(data) {
    alert("Список млекопитающих очищен!");
}


function OnSuccessArti(data) {
    $.ajax({
        url: "https://localhost:44352/Home/ArtiJson",
        contentType: "application/json",
        method: "GET",
        cache: false,
        success: function (response) {
            var data = "";
            for (var i = 0; i < response.length; i++) {
                data += "////////////////////////////////" + "\n" + "Наименование: " +
                    response[i].Name + "\n" + "Количество копыт:  " + response[i].Hoofs + "\n" + "Животное жвачное:  " + response[i].IsRum + "\n";
            }
            alert(data);
        },
        error: function (jxqr, error, status) {
            alert("Ошибка " + jxqr.statusText)
        }
    })
}

function OnSuccessAddArti(data) {
    alert("Объект успешно добавлен");
}

function OnSuccessRemoveArti(data) {
    alert("Список парнокопытных очищен!");
}