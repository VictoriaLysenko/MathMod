$("#decideEquation").submit(function (event) {
        event.preventDefault();
        let form = event.target,
            startValue = form.elements.startValue.value,
            EndValue = form.elements.EndValue.value,
            //NumberOfStep = form.elements.NumberOfStep.value,
            method = form.elements.method.value;

        let results = document.getElementsByClassName("result")[0];

        let params = {
            startValue, EndValue,
            //NumberOfStep
        };
        $.ajax({
            type: "POST",
            url: `/methods/${method}/`,
            data: JSON.stringify(params),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: successFunc,
            //error: errorFunc
        });

        function successFunc(data, status) {
            if (status == "success") {
                console.log(data);
                let resultTable = '',
                    index = 0;
                Object.entries(data).forEach(([key, value]) => {
                    resultTable += `<tr><th scope="row">${index}</th><td>${key}</td><td>${value}</td></tr>`;
                    index += 1;
                });
                $("#result").html(resultTable);
               
            }
        }
    });