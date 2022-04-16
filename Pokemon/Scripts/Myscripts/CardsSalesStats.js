
    var settings = {
        "url": "https://localhost:44324/api/CardStatistics?name=@Model.Name",
    "method": "GET",
    "timeout": 0,
        };

    $.ajax(settings).done(function (response) {

        window.onload = function () {

            var chart = new CanvasJS.Chart("chartContainer", {
                theme: "dark2",
                animationEnabled: true,
                title: {
                    text: "Email Categories",
                    horizontalAlign: "left"
                },
                data: [{
                    type: "doughnut",
                    startAngle: 60,
                    //innerRadius: 60,
                    indexLabelFontSize: 17,
                    indexLabel: "{label} - #percent%",
                    toolTipContent: "<b>{label}:</b> {y} (#percent%)",
                    dataPoints: [
                        response[0],
                        response[1],
                        response[2]
                    ]
                }]
            });
            chart.render();

        }

    });

