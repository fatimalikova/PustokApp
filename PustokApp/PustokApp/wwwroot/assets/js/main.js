$(document).ready(function () {
    $(".bookModalIcon").click(function () {
        let url = $(this).attr("href");
        fetch(url)
            .then(response => response.text())
            .then(data => {
                $("#quickModal .modal-dialog").html(data);


});
