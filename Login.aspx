﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IdealResidencia.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Ideal Residencia</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
	<meta charset="UTF-8" />
	<meta name="keywords" content="Video Login Form Responsive Widget,Login form widgets, Sign up Web forms , Login signup Responsive web form,Flat Pricing table,Flat Drop downs,Registration Forms,News letter Forms,Elements"
     />
    <script>
		addEventListener("load", function () {
			setTimeout(hideURLbar, 0);
		}, false);

		function hideURLbar() {
			window.scrollTo(0, 1);
		}
	</script>
	<!-- Meta tag Keywords -->
	<!-- css files -->
	<link rel="stylesheet" href="Login/css/style.css" type="text/css" media="all" />
	<!-- Style-CSS -->
	<link rel="stylesheet" href="Login/css/fontawesome-all.css" />
	<!-- Font-Awesome-Icons-CSS -->
	<!-- //css files -->
	<!-- web-fonts -->
	<link href="//fonts.googleapis.com/css?family=Marck+Script&amp;subset=cyrillic,latin-ext" rel="stylesheet" type="text/css" />
	<link href="//fonts.googleapis.com/css?family=Montserrat:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=cyrillic,latin-ext"
	    rel="stylesheet" type="text/css" />
	<!-- //web-fonts -->
</head>
<body>
    <div class="video-w3l" data-vide-bg="Login/video/1">
		<!-- title -->
		<h1>
			<span>V</span>ideo
			<span>L</span>ogin
			<span>F</span>orm</h1>
		<!-- //title -->
		<!-- content -->
		<div class="sub-main-w3">
			<form runat="server" method="post">
				<div class="form-style-agile">
					<label>
						<i class="fas fa-user"></i>Username</label>
					<asp:TextBox runat="server" ID="tb_username" placeholder="Username" />
				</div>
				<div class="form-style-agile">
					<label>
						<i class="fas fa-unlock-alt"></i>Password</label>
                    <asp:TextBox runat="server" ID="tb_password" placeholder="Password" TextMode="Password" />
				</div>
				<!-- switch -->
				<div class="checkout-w3l">
					<div class="demo5">
						<div class="switch demo3">
							<input type="checkbox" />
							<label>
								<i></i>
							</label>
						</div>
					</div>
					<a href="#">Remember Me</a>
				</div>
				<!-- //switch -->
				<asp:Button ID="BtnLogin" runat="server" Text="Log In" OnClick="BtnLogin_Click" />
				<!-- social icons -->
				<div class="footer-social">
					<h2>Or Login With</h2>
					<ul>
						<li>
							<a href="#">
								<i class="fab fa-facebook-f icon_facebook"></i>
							</a>
						</li>
						<li>
							<a href="#">
								<i class="fab fa-twitter icon_twitter"></i>
							</a>
						</li>
						<li>
							<a href="#">
								<i class="fab fa-dribbble icon_dribbble"></i>
							</a>
						</li>
						<li>
							<a href="#">
								<i class="fab fa-google-plus-g icon_g_plus"></i>
							</a>
						</li>
					</ul>
				</div>
				<!-- //social icons -->
			</form>
		</div>
		<!-- //content -->

		<!-- copyright -->
		<div class="footer">
			<p>&copy; 2018 Video Login Form. All rights reserved | Design by
				<a href="http://w3layouts.com">W3layouts</a>
			</p>
		</div>
		<!-- //copyright -->
	</div>

    <!-- Jquery -->
	<script src="Login/js/jquery-2.2.3.min.js"></script>
	<!-- //Jquery -->

	<!-- Video js -->
	<script src="Login/js/jquery.vide.min.js"></script>
	<!-- //Video js -->
	
</body>
</html>
