var express = require('express');
var app = express();

const webPage1 = `

<html>

<style>

h1 {
	color: red;
	font-size: 80px;
	font-family: 'arial';
}

</style>

<body>

<h1>wanna see a horsy?</h1>
<a href="/page2">go</a>

</body>

</html>

`;

const webPage2 = `

<html>

<style>

h1 {
	color: red;
	font-size: 80px;
	font-family: 'arial';
}

</style>

<body>

<h1>this is a horsy!</h1>
<img src="http://cl.jroo.me/z1/F/A/o/e/a.caa-small-Funny-Looking-Horse-.jpg" />
<a href="/">go home</a>

</body>

</html>

`;

app.get('/', function(req, res){
  res.send(webPage1);
});

app.get('/page2', function(req, res){
  res.send(webPage2);
});

app.listen(3000);