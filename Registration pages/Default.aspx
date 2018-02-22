    <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
      <title>Technology - BBC News</title>
    <style type="text/css">
        #topbar 
     {
    width:100%;
    margin:0 auto;
    height:45px
    }

    body{
    padding:0;
    margin:0;
    font-family: Helvetica,Arial,sans-serif
    }

    #logo{
    margin-top:10px;
    width:100px;
    float:left;
    margin-right:15px;
    margin-left:15px;
    height:70%
    }
    .topbar-section
    {

    float:left;
    border-left:1px grey solid;
    height:100%;

    }
    #signimg{
    height:65%;
    margin-top:8px;
    margin-left:10px;
    float:left
    }

    #signtxt{
    font-weight:bold;
    font-size:100%;
    position:relative;
    top:12px;
    margin-left:8px;
    margin-right:58px;
    }
    #bellimg{
    float:left;
    height:65%;
    margin-left:10px;
    margin-top:8px;
    margin-right:8px;
    }
    .topbar-menu{
    font-weight:bold;
    font-size:100%;
    padding:14px 25px 0 15px;
    height:32px;
    }
    #moreimg{
    width:12px;

    }
    #searchtxt{
    height:26px;
    margin:10px 0 5px 5px;
    float:left;

    }
    #searchimg{
    height:28px;
    margin-top:8px;



    }
    .clear{
    clear:both;
    }
    .menu-container{
    background-color:#BB1919;
    width:100%;
    height:70px;
    }
    #menu-items{
    width:100%;
    margin:0 auto;
    }
    h1{
    padding:0;
    margin:0;
    font-size:40px;
    color:white;
    font-weight:normal;
    padding-top:10px;
    padding-left:10px;
    float:left;
    }
    #locationimg{
    width:25px;

    }
    #Localnews{
    float:right;
    margin-top:18px;
    border:1px #BB4545 solid;
    width:180px;
    padding:5px 5px 5px 5px;

    }
    #Localnews a{
    color:white;
    text-decoration:none;
    font-size:20px;
    }
    #Localnews a:hover{
    text-decoration:underline;
    }
    .menu-container2{
    background-color:#A91717;
    width:100%;
    }
    .menu-items2{
    width:100%;
    margin:0 auto;
    height:30px;

    }
    .menu-items2 a{
    color:white;
    text-decoration:none;
    border-right:1px #BB4545 solid;
    margin-top:10px;
    margin-left:10px;
    padding:0px 10px;
    font-size:20px;
    position:relative;
    top:5px;
    }
    .menu-items2 a:hover{
    text-decoration:underline;
    }
    .noborder{
    border:none !important;

    }
    #downimg{
    width:12px;
    position:relative;
    top:5px;
    }
    .page-container{
    width:90%;
    margin:0 auto;
    }
    h2{
    font-weight:normal;
    margin-top:20px;
    font-size:20px;
    border-bottom:3px solid #A91717;
    width:100px;
    }
    h3 a{
    color:black;
    font-size:25px;
    text-decoration: none;

    }
    h3 a:hover{
    color:#1167A8;
    }
    .article-summary{
    color:#5A5A5A;
    width:340px;
    float:left;
    }
    .cloock{
    width:15px;
    position:relative;
    top:2px;

    }
    .article-summary a{
    text-decoration:none;
    color:A91717;
    }
    .article-summary a:hover{
    color:#1167A8;

    }
    #articlecont{
    float:left;
    width:790px;
    border-right:1px solid #cccccc;
    }

    #artimg{
    width:400px;
    }
    #art2img{
    width:400px;
    }
    #arthr{
    border-top:1px solid #A91717;
    width:50px;
    }
    #art2hr{
    border-top:1px solid #A91717;
    width:250px;
    }
    #topicc{
    color:grey;
    text-decoration:none;
    }
    #watch-list{
    margin-left:30px;
    width:300px;
    float:right;
    position:relative;
    top:-590px;
    left:-20px;
    }

    h4{
    font-weight:normal;
    font-size:20px;
    }
    .sideimg{
    float:left;
    width:90px;
    margin-right:10px;
    }
    .vid1{
    text-decoration:none;
    color:black;
    font-weight:bold;
    font-size:18px;
    }
    .vid1:hover{
    color:#1167A8;
    }
    .side-article{

    }
    #equal{
	    margin-top:150px;
	    align:"left|center|right";
	    border-top:1px solid #A91717;
    width:1050px;
    position:relative;
    top:-250px;
    }
    .social{
	    font-weight:bold;
	    font-size:30px;
	    float:left;
	    position:relative;
    top:-250px;
    float:left;
	
    }
    .lining{
	    width:55px;
	    float:left;
	    margin-right:100px;
	    cursor: pointer;
    }
    #copy{
	    position:relative;
	    top:-200px;
	    left:75px;
    }

    </style>
    </head>
    <body>
        <form id="form1" runat="server">
 
    <div id="topbar">
    <img id="logo" src="images/BBC.png">
	    <div id="Signin" class ="topbar-section">
		    <img id="signimg" src="images/Sign%20in.png">
		    <a href="Login page.aspx" id="signtxt">Sign in</a>
	    </div>
	
	    <div id="belly" class="topbar-section">
		    <img id="bellimg" src="images/bell.png">
	    </div>
	
    <div class="topbar-section topbar-menu">
    Home
    </div>	
    <div class="topbar-section topbar-menu">
    News
    </div>
    <div class="topbar-section topbar-menu">
    Sport
    </div>
    <div class="topbar-section topbar-menu">
    Weather
    </div>
    <div class="topbar-section topbar-menu">
    iplayer
    </div>
    <div class="topbar-section topbar-menu">
    Tv
    </div>
    <div class="topbar-section topbar-menu">
    Radio
    </div>
    <div class="topbar-section topbar-menu">
    More
    <img id="moreimg" src="images/more.png" >
    </div >
    <div class="topbar-section">
    <input id="searchtxt" type="text" placeholder="search">
    <input type="image" id="searchimg" src="images/search.png" >
    </div>
    <div class="clear" ></div>

    <div class="menu-container" >
	    <div id="menu-items">
	    <h1>NEWS</h1>
	    <div id="Localnews"> <a href="">Find local News</a>
	    <img id="locationimg" src="images/location.png" >
    </div>
     </div>
     </div>
     <div class="clear"></div>
     <div class="menu-container2">
     <div class="menu-items2">
     <a href="">Home</a>
     <a href="">UK</a>
     <a href="">World</a>
     <a href="">Business</a>
     <a href="">politics</a>
     <a href="">Tech</a>
     <a href="">Science</a>
     <a href="">Health</a>
     <a href="">Education</a>
     <a href="">Entertainment & Arts</a>
     <a href="">video & Audio</a>
     <a class="noborder" href="">More</a>
     <img id ="downimg" src="images/more.png" >
     </div>
     </div>
     <div class="clear"> </div>
     <div class ="page-container">
     <div class="main-article">
     <h2>Technology</h2>
     <div id="articlecont">
     <h3><a href="">Russian fighter jet shot down in Syria</a></h3>
     <div class="article-summary">
     The Sukhoi-25 crashes in a rebel-held area in Idlib and the pilot is killed in a firefight, Russia says. 
     <p><img class="cloock" src="images/clock.png" > 3 february 2018 | <a href="">Technology</a></p>
     <hr id="arthr" align ="left">
     <p><a id ="topicc" href="">Outcry over dead Kurdish fighter</a></p>
    <p><a id ="topicc" href="">Why target Kurdish forces?</a></p>
    <p><a id ="topicc" href="">Afrin: A prize worth a war</a></p>
     </div>
     <img id="Artimg" src="images/russia.jpg">
     <hr id="art2hr" align ="left">
     </div>
     <div id="articlecont">
      <h3><a href="">Syria war: Turkey suffers deadliest day in Afrin offensive</a></h3>
      <div class="article-summary">
     The Turkish military has suffered the deadliest day in its offensive against Kurdish militias inside northern Syria, with seven soldiers killed. 
     <p><img class="cloock" src="images/clock.png" > 3 february 2018 | <a href="">Technology</a></p>
     <hr id="arthr" align ="left">

     </div>
      <img id="Art2img" src="images/turkey.jpg" >
     </div>
 
     </div>
     <div class="clear"></div>
     <div id="watch-list">
     <h4>Watch/Listen</h4>
     <img class="sideimg" src="images/img1.JPG" >
     <div class="side-article">  
     <p><a class="vid1" href="">Sean Spicer on having Trump as boss</a></p>
     <p><img class="cloock" src="images/clock.png" > 3 february 2018 | <a href="">Technology</a></p>
     </div>
     <div class="clear"></div>
     <img class="sideimg" src="images/img2.JPG" >
     <div class="side-article">  
     <p><a class="vid1" href="">4,400-year-old tomb discovered in Egypt</a></p>
     <p><img class="cloock" src="images/clock.png" > 3 february 2018 | <a href="">Technology</a></p>
     </div>
     <div class="clear"></div>
     <img class="sideimg" src="images/img3.JPG" >
     <div class="side-article">  
     <p><a class="vid1" href="">Victims' father attacks Larry Nassar</a></p>
     <p><img class="cloock" src="images/clock.png" > 3 february 2018 | <a href="">Technology</a></p>
     </div>
 
    </div>

    <hr id="equal">
     <div class="social">
    <p> Find Us Here</p>
    <input type="image" class ="lining"   src="images/twitter.png" >
    <input type="image" class ="lining"   src="images/facebook.png" >
    <input type="image" class ="lining"   src="images/whatsapp.png" >
    <input type="image" class ="lining"   src="images/insta.jpg" >

     </div>
     </div>
     <div class="clear"></div>
    <div id="copy">
     <p>Copyright © 2018 Vijay Bommagani LLC. Bommagani is not responsible for the content of external sites</p>
     </div>
    </div>
            </form>
    </body>

    </html>
    

