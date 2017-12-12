document.forms['decideEquation'].onsubmit = function (event) {
    let form = event.target,
        equation = form.elements.equation.value,
        koshi = form.elements.koshi.value,
        method = form.elements.method.value;

    let results = document.getElementsByClassName("result")[0];

    let params = { equation, koshi };
    $.ajax({
        type: "POST",
        url: "/methods/TestPost/",
        data: JSON.stringify(params),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: successFunc,
        //error: errorFunc
    });

    function successFunc(data, status) {

    $(".result").html(data);
        console.log(data, status, 'success');
    }
    return false;
}