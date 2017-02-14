$(function(){
  var rotationValueHour = $(".clock-hour").attr("value") - 90;
  var rotationValueMinute = $(".clock-minutes").attr("value") - 90;
  $(".clock-hour").css({'transform' : 'rotate('+ rotationValueHour +'deg)'});
  $(".clock-minutes").css({'transform' : 'rotate('+ rotationValueMinute +'deg)'});
});
