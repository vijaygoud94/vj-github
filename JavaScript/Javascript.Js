var start= new Date().getTime();
function randomcolor(){
var letters='0123456789ABCDEF'.split('');
var color='#';
for(var i=0;i<6;i++){
color +=letters[Math.floor(Math.random() *16)];
}
return color;
}

function vijay(){
var top = Math.random()*400;
var left = Math.random()*400;
var width = (Math.random() *200)+100;
if(Math.random()> 0.5){
document.getElementById("shape").style.borderRadius ="50%";
}
else{
document.getElementById("shape").style.borderRadius ="0";
}
document.getElementById("shape").style.backgroundColor= randomcolor();

document.getElementById("shape").style.width = width + "px";
document.getElementById("shape").style.height = width + "px";
document.getElementById("shape").style.top = top + "px";
document.getElementById("shape").style.left = left+ "px";
document.getElementById("shape").style.display="block";
}
function appear(){
setTimeout(vijay, Math.random() * 2000);
}
appear();
document.getElementById("shape").onclick = function(){
var end= new Date().getTime();
document.getElementById("shape").style.display = "none";
var timetaken=(end-start)/1000;
document.getElementById("timetakes").innerHTML=timetaken+"'s";
appear();
}