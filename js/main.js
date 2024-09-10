document.getElementById("main-form").addEventListener("submit", checkForm);

function checkForm(event) {
    event.preventDefault();
    var el = document.getElementById("main-form");

    var name = el.name.value;
    var pass = el.pass.value;
    var repass = el.repass.value;
    var state = el.state.value;

    var fail = "";

    if (name == "" || pass == "" || state == "")
        fail = "Заполните все поля";
    else if (name.length <= 1 || name.length > 50)
        fail = "Введите корректное имя";
    else if (pass != repass)
        fail = "Пароли должны совпадать";
    else if (pass.split("&").length > 1)
        fail = "Некорректный пароль";

    if (fail != "")
        document.getElementById("error").innerHTML = fail;
    else {
        document.getElementById("error").innerHTML = "";

        // Отправка данных на сервер через AJAX
        var xhr = new XMLHttpRequest();
        xhr.open("POST", "/api/UserController/SaveUserData", true);
        xhr.setRequestHeader("Content-Type", "application/json;charset=UTF-8");

        xhr.onreadystatechange = function () {
            if (xhr.readyState === 4 && xhr.status === 200) {
                alert("Данные успешно отправлены");
            }
        };

        var data = {
            Name: name,
            Password: pass,
            Gender: state
        };

        xhr.send(JSON.stringify(data));
    }
}
