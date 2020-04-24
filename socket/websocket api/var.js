var express=require('express');
var socket =require("socket.io");   // we require for websocketing.
var app=express();
var server=app.Listen(2000,function()
{
    console.log('listening to the request part');

});

app.use(express.static('publ'));

//socket setup

var s= socket(server)  /*server is sitting in socket 
                         to establish a connection between the server
                          and client*/
io.on('connetion',function(socket)
{
    console.log('made connections');
});