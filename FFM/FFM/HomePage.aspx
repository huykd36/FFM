﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FFM.HomePage" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Document</title>
        <link rel="stylesheet" href="./CSS/style.css">
    </head>

    <body>
        <form id="form1" runat="server">
            <header>
                <h2 class="logo">Football</h2>
                <nav class="navigation">
                    <a href="#">Home</a>
                    <a href="#">Booking</a>
                    <a href="#">About us</a>
                    <button class="btnLogin-popup">Login</button>
                </nav>
            </header>

            <div class="wrapper">
                <span class="icon-close"><ion-icon name="close"></ion-icon></span>
                <div class="form-box login">
                    <h2>Login</h2>
                    <form action="#">
                        <div class="input-box">
                            <span class="icon"><ion-icon name="mail"></ion-icon></span>
                            <input type="email" required>
                            <label>Email</label>
                        </div>
                        <div class="input-box">
                            <span class="icon"><ion-icon name="lock-closed"></ion-icon></span>
                            <input type="password" required>
                            <label>Password</label>
                        </div>
                        <div class="remember-forgot">
                            <label>
                                <input type="checkbox"> Remember me
                            </label>
                        </div>
                        <button type="submit" class="btn_login">Login</button>
                        <div class="login-register">
                            <p>
                                Don't have a account?
                                <a href="#" class="register-link">Register</a>
                            </p>
                        </div>
                    </form>
                </div>

                <div class="form-box register">
                    <h2>Registration</h2>
                    <form action="#">
                        <div class="input-box">
                            <span class="icon"><ion-icon name="person"></ion-icon></span>
                            <input type="text" required>
                            <label>Username</label>
                        </div>
                        <div class="input-box">
                            <span class="icon"><ion-icon name="mail"></ion-icon></span>
                            <input type="email" required>
                            <label>Email</label>
                        </div>
                        <div class="input-box">
                            <span class="icon"><ion-icon name="lock-closed"></ion-icon></span>
                            <input type="password" required>
                            <label>Password</label>
                        </div>
                        <div class="remember-forgot">
                            <label>
                                <input type="checkbox"> I agree to the terms & conditions
                            </label>
                        </div>
                        <button type="submit" class="btn_register">Register</button>
                        <div class="login-register">
                            <p>
                                Already have an account?
                                <a href="#" class="login-link">Login</a>
                            </p>
                        </div>
                    </form>
                </div>
            </div>

            <script src="Javascripts/script.js"></script>

            <script type="module" src="https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.esm.js"></script>
            <script nomodule src="https://unpkg.com/ionicons@7.1.0/dist/ionicons/ionicons.js"></script>
        </form>
    </body>

    </html>