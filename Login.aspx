<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://apis.google.com/js/platform.js" async defer></script>
    <meta name="google-signin-client_id" content="902260506146-7gv3hprd984niiconushaf772ihg9r1t.apps.googleusercontent.com" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="g-signin2" data-onsuccess="onSignIn"></div>
            <a href="SelectNote.aspx" onclick="signOut();">Sign out</a>

        </div>
        <script>
            function onSignIn(googleUser) {
                var profile = googleUser.getBasicProfile();
                console.log('ID: ' + profile.getId()); 
                console.log('Name: ' + profile.getName());
                console.log('Image URL: ' + profile.getImageUrl());
                console.log('Email: ' + profile.getEmail());
            }
            function signOut() {
                var auth2 = gapi.auth2.getAuthInstance();
                auth2.signOut().then(function () {
                    console.log('User signed out.');
                });
            }
        </script>
    </form>
</body>
</html>
