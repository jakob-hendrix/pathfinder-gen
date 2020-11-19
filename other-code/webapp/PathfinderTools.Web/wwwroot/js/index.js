// setup a local scope for this file
$(document).ready(function () {
  var x = 0;
  var s = "";

  console.log("Hello");

  var theForm = $("#theForm");
  theForm.hide();

  var button = $("#editButton");
  button.on("click",
    function() {
      console.log("Editing current character");
    }
  );

  var characterDetails = $(".characterDetails li");

// set up events on a collection of items
  characterDetails.on("click",
    function() {
      console.log("You clicked on " + $(this).text());
    }
  );


  var $loginToggle = $("#loginToggle");
  var $popupForm = $(".popupForm");

  // click the login to hide or reveal the form
  $loginToggle.on("click", function() {
    $popupForm.fadeToggle(150);
  })


})