function init() {
  const API = "https://api.covid19api.com/summary";
  $.get(API, function (data) {
    console.log(data.Global);

    data = `
                    <td>${data.Global.TotalConfirmed}</td>
                     <td>${data.Global.TotalDeaths}</td>
                     <td>${data.Global.NewRecovered}</td>
            `;
    $("#data").html(data);
  });
}

$(".btn").click(function () {
  $("#data").empty();
  clearData();
});

function clearData() {
  init();
}

init();
