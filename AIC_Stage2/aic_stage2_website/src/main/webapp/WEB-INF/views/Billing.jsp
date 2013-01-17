<%@page contentType="text/html;charset=UTF-8" %>
<%@page pageEncoding="UTF-8" %>
<%@ page session="false" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8"/>
<link rel="shortcut icon" type="image/ico" href="/images/favicon.ico"/>
<title>Overview - Welcome to Statistico</title>
<!--<link href="styles.css" type="text/css" media="screen" rel="stylesheet" />-->
<style type="text/css">
img, div {
    behavior: url(iepngfix.htc)
}

    /* CSS RESET */

html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, font, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td {
    margin: 0;
    padding: 0;
    border: 0;
    outline: 0;
    font-weight: inherit;
    font-style: inherit;
    font-size: 100%;
    font-family: inherit;
    vertical-align: baseline;
}

    /* remember to define focus styles! */
:focus {
    outline: 0;
}

body {
    line-height: 1;
}

ol, ul {
    list-style: none;
}

    /* tables still need 'cellspacing="0"' in the markup */
table {
    border-collapse: separate;
    border-spacing: 0;
}

caption, th, td {
    text-align: left;
    font-weight: normal;
}

blockquote:before, blockquote:after,
q:before, q:after {
    content: "";
}

blockquote, q {
    quotes: "" "";
}

    /* HTML, BODY, GENERAL SETUP */

html {
    background: #63bad8 url(../images/bg.jpg) 50% 0px repeat-x;
    text-align: center;
}

body {
    text-align: center;
    font: 12px 'Lucida Grande', lucida, helvetica, arial, sans-serif;
    color: #333333;
    padding: 0px;
    margin: 0 auto;
    width: 840px;
}

#wrappertop {
    width: 800px;
    height: 20px;
    padding: 0 20px 0 20px;
    margin-top: 20px;
}

#wrapperbottom {
    width: 800px;
    height: 20px;
    padding: 0 20px 0 20px;
    margin-bottom: 20px;
}

#wrapper {
    width: 800px;
    padding: 0 20px 0 20px;
    position: relative;
}

#content {
    width: 800px;
    background-color: #fff;
    text-align: center;
}

#ajaxlink {
    width: 230px;
    float: right;
}

.greenlink {
    line-height: 14px;
    font-style: normal;
    background: #d8f2c9;
    border-bottom: 1px solid #30940b;
    color: #30940b;
    font-weight: bold;
    text-decoration: none;
    padding: 4px;
}

.greenlink_no_left_padding {
    line-height: 14px;
    font-style: normal;
    background: #d8f2c9;
    border-bottom: 1px solid #30940b;
    color: #30940b;
    font-weight: bold;
    text-decoration: none;
    padding-right: 4px;
    padding-top: 4px;
    padding-bottom: 4px;
}

.greenlink img {
    margin: 4px 8px 0 0;
    vertical-align: text-bottom;
}

.dash-link {
    bottom: 200px;
    line-height: 14px;
    font-style: normal;
    background: #d8f2c9;
    border-bottom: 1px solid #30940b;
    color: #30940b;
    font-weight: bold;
    text-decoration: none;
    padding: 4px;
}

.dash-link img {
    text-decoration: none;
    margin: 4px 0px 0 0;
    vertical-align: text-bottom;
    background: #d8f2c9;
    color: #30940b;
}

    /* HEADER */

#header {
    width: 780px;
    background: #c5e6ea;
    padding: 25px 0 5px 20px;
    border-bottom: #b2ccd0 solid 1px;
}

h1 {
    margin-top: 15px;
    display: inline;
    width: 220px;
}

#usercontainer {
    text-align: right;
    width: 560px;
    float: right;
    padding-top: -20px;
    _margin-top: -20px;
}

.boldtext {
    font-weight: bold;
}

#user-options {
    right: 0;
    float: right;
    margin-top: 5px;
}

#user-options, x:-moz-any-link {
    margin-top: -15px;
}

body.staff ul#user-options {
    margin-right: 20px;
}

#user-options a {
    color: #333333;
}

#user-options a:hover {
    color: #104b67;
}

#user-options li {
    display: inline;
    margin-left: 8px;
}

.support-link {
    padding: 5px 5px 5px 5px;
    _padding: 10px 5px 5px 5px;
    _margin-top: -5px;
    background: #9fd2d8;
    text-decoration: none;
    font-weight: bold;
    display: block;
    margin-left: 5px;
}

.support-link:hover {
    background: #92cad1;
}

    /* CLIENT SIDE NAVIGATION */

.dashboard-box {
    float: left;
    overflow: hidden;
}

ul#clientmenu {
    top: 0;
    position: relative;
    width: 800px;
    margin: 0;
    padding: 0;
    height: 90px;
    list-style-type: none;
    display: inline-block;
    _height: 1%;
}

ul#clientmenu:after {
    content: ".";
    display: block;
    clear: both;
    height: 0;
    visibility: hidden;
}

ul#clientmenu li a {
    width: 159px;
    text-decoration: none;
    height: 50px !important;
    height /**/: 90px; /* IE5/Win */
    float: left;
    margin: 0;
    padding: 20px;
    font: bold 20px helvetica, arial, sans-serif;
    color: #000;
    border-left: 1px solid #ffffff;
    overflow: hidden;
    list-style-type: none;
    background: #c2c2c2 url(../images/navbg.png) repeat-x;
}

#clientmenu li#myaccount a {
    border: 0;
    padding-left: 21px;
}

ul#clientmenu span {
    font: 11px 'Lucida Grande', lucida, helvetica, arial, sans-serif;
    color: #333333;
    margin-top: 4px;
    display: block;
}

#clientmenu li a:hover {
    background: #c2c2c2 url(../images/navbghover.png) repeat-x;
}

li {
    float: left;
}

body#myaccountpage li#myaccount a,
body#myprojectspage li#myprojects a,
body#billingpage li#billing a,
body#messagecenterpage li#messagecenter a {
    background: #fff;
}

    /* STAFF SIDE NAVIGATION */

ul#staffmenu {
    top: 0;
    position: relative;
    width: 790px;
    margin: 0;
    padding: 0 0 0 10px;
    height: 40px;
    list-style-type: none;
    display: inline-block;
    _height: 1%;
    background: #c2c2c2 url(../images/staffnavbg.png) repeat-x;
}

ul#staffmenu:after {
    content: ".";
    display: block;
    clear: both;
    height: 0;
    visibility: hidden;
}

ul#staffmenu li a {
    text-decoration: none;
    height: 16px !important;
    height /**/: 40px; /* IE5/Win */
    float: left;
    margin: 0;
    padding: 12px 10px 12px 10px;
    font: bold 14px helvetica, arial, sans-serif;
    color: #000;
    border-right: 1px solid #ffffff;
    overflow: hidden;
    list-style-type: none;
}

ul#staffmenu span {
    font: 11px 'Lucida Grande', lucida, helvetica, arial, sans-serif;
    color: #333333;
    margin-top: 4px;
    display: block;
}

#staffmenu li a:hover {
    background: #c2c2c2 url(../images/staffnavbghover.png) repeat-x;
}

li {
    float: left;
}

body#clientfunctionspage li#clientfunctions a,
body#projectfunctionspage li#projectfunctions a,
body#billingtoolspage li#billingtools a,
body#supportpage li#support a,
body#administrationpage li#administration a,
body#myaccountpage li#myaccount a {
    background: #fff;
}

    /* ACTIVE INVOICES TITLE */

#darkbanner {
    margin: 20px 0 0 -40px;
    padding: 8px 10px 10px 4px;
    background: #424242;
    position: relative;
}

#darkbanner span {
    padding-left: 35px;
    color: #fff;
    display: block;
}

#darkbannerwrap {
    background: url(../images/aiwrap.png);
    width: 18px;
    height: 10px;
    margin: 0 0 20px -18px;
    position: relative;
}

    /* COMPLETED INVOICES TITLE */

#lightbanner {
    margin: 20px 0 0 -18px;
    padding: 8px 10px 10px 40px;
    background: #b6b6b6;
    position: relative;
}

#lightbanner span {
    padding-left: 35px;
    color: #fff;
    display: block;
}

#lightbannerwrap {
    background: url(../images/ciwrap.png);
    width: 18px;
    height: 10px;
    margin: 0 0 20px -18px;
    position: relative;
}

    /* TITLE WIDTHS */

.banner450 {
    width: 450px;
}

.banner285 {
    width: 285px;
}

.banner320 {
    width: 500px;
}

.banner350 {
    width: 350px;
}

.banner380 {
    width: 380px;
}

.banner410 {
    width: 410px;
}

    /* TABLES */

th {
    font-weight: bold;
    padding: 8px 10px 8px 10px;
}

th.number {
    text-align: right;
    padding-right: 13px;
}

td {
    border-bottom: 10px solid #fff;
}

td {
    padding: 8px 10px 8px 10px;
}

td.number {
    font-weight: bold;
    text-align: right;
    width: 30px;
}

td.number a {
    font-weight: bold;
    color: #30940b;
    text-decoration: none;
}

td.number a:hover {
    color: #1c6203;
}

td.number1 {
    max-height: 10px;
    font-weight: bold;
    text-align: right;
    width: 30px;
    height: 10px;
}

td.projectback span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.projectback span a:hover {
    color: #666;
}

td.td45 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 25px;
}

td.td65 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 45px;
}

td.td80 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 60px;
}

td.td90 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 70px;
}

td.td100 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 80px;
}

td.td100b {
    width: 80px;
}

td.td120 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 100px;
}

td.td150 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 130px;
}

td.td180 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 160px;
}

td.td200 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 180px;
}

td.td220 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 200px;
}

td.td220b {
    width: 200px;
}

td.td250 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 230px;
}

td.td260 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 240px;
}

td.td250b {
    width: 230px;
}

td.td290b {
    width: 270px;
}

td.td290b span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td290b span a:hover {
    color: #666;
}

td.td300 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 280px;
}

td.td300b {
    width: 280px;
}

td.td300b span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td300b span a:hover {
    color: #666;
}

td.td325 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 305px;
}

td.td325 span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td325 span a:hover {
    color: #666;
}

td.td325b {
    width: 305px;
}

td.td335 {
    width: 315px;
}

td.td335 span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td335 span a:hover {
    color: #666;
}

td.td340 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 320px;
}

td.td340 span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td340 span a:hover {
    color: #666;
}

td.td340b {
    width: 320px;
}

td.td340b span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td340b span a:hover {
    color: #666;
}

td.td350 {
    font-weight: bold;
    width: 330px;
}

td.td350 span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td350 span a:hover {
    color: #666;
}

td.td370b {
    width: 350px;
}

td.td370b span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td370b span a:hover {
    color: #666;
}

td.td400 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 380px;
}

td.td400 span a {
    padding-left: 10px;
    font: normal 10px 'Lucida Grande';
    color: #999999;
}

td.td400 span a:hover {
    color: #666;
}

td.td500 {
    background: url(../images/tabledivider.png) no-repeat;
    width: 480px;
}

td.paynow {
    background: #d8f2c9;
    text-align: center;
    width: 80px;
}

td.paynow a {
    font-weight: bold;
    color: #30940b;
    text-decoration: none;
}

td.paynow a:hover {
    color: #1c6203;
}

td.beenpaid {
    background: #ebf8e4;
    text-align: center;
    width: 80px;
}

td.beenpaid a {
    font-weight: bold;
    color: #8dc677;
    text-decoration: none;
}

td.beenpaid a:hover {
    color: #30940b;
}

td.wfaction {
    background: #d8f2c9;
    text-align: center;
    width: 120px;
}

td.wfaction a {
    font-weight: bold;
    color: #30940b;
    text-decoration: none;
}

td.wfaction a:hover {
    color: #1c6203;
}

td.tddarkred {
    background-color: #c93737;
}

td.tdmidred {
    background-color: #dd8282;
}

td.tdlightred {
    background-color: #f8e6e6;
}

td.tdlightgreen {
    background-color: #ebf8e4;
}

td.tdmidgreen {
    background-color: #d8f2c9;
}

td.tdmidorange {
    background-color: #ffc14c;
}

td.tdmidblue {
    background-color: #bddef7;
}

td.tdmidyellow {
    background-color: #f7f6b4;
}

td.tdgrey {
    background-repeat: repeat-x;
    background-image: url(../images/grey-table-fill.png);
    border-collapse: separate;
    max-height: 10px;
    height: 10px;
    background-color: white;
}

td.tdlightgrey {
    background-color: #b6b6b6;
}

.redtext {
    font-weight: bold;
    color: #800a13;
}

.greentext {
    font-weight: bold;
    color: #30940b;
}

.bluetext {
    font-weight: bold;
    color: #293794;
}

.orangetext {
    font-weight: bold;
    color: #d46a00;
}

.yellowtext {
    font-weight: bold;
    color: yellow;
}

.whitetext {
    font-weight: bold;
    color: white;
}

td.actions {
    background: #dbeff2;
    width: 80px;
    border-left: 10px solid #fff;
}

td.actions img {
    margin-right: 10px;
}

td.actionslong {
    background: #dbeff2;
    width: 100px;
    border-left: 10px solid #fff;
}

td.actionslong img {
    margin-right: 10px;
}

    /* SYSTEM ANNOUNCEMENTS - client */

#systemannouncement p {
    padding-left: 10px;
    padding-bottom: 2px;
    padding-right: 10px;
    padding-top: 10px;
    display: block;
    border: 2px solid #bc6f6b;
    background: #eac5c5;
    margin-left: 15px;
    margin-right: 15px;
    margin-bottom: 10px;
}

#systemannouncement td {
    border-bottom: 8px solid #fff;
    padding: 0px 0px 2px 10px;
}

    /* My Messages - Message.php Page */
#readreplymsg td {
    border-bottom: 0px solid #fff;
    padding: 0px 0px 10px 15px;
    margin-left: 15px;
}

    /* CLIENT SUPPORT ELEMENTS */

td.support-open {
    background: #d8f2c9;
    text-align: center;
    width: 80px;
    font-weight: bold;
    color: #30940b;

}

td.support-open a {
    font-weight: bold;
    color: #30940b;
    text-decoration: none;
}

td.support-open a:hover {
    color: #1c6203;
}

td.support-closed {
    background: #dd8282;
    text-align: center;
    width: 80px;
    font-weight: bold;
    color: #800a13;
}

td.support-closed a {
    font-weight: bold;
    color: #800a13;
    text-decoration: none;
}

td.support-closed a:hover {
    color: #58060c;
}

#supportreply p.staff {
    padding-left: 10px;
    padding-bottom: 10px;
    padding-right: 10px;
    padding-top: 10px;
    display: block;
    background-color: #d8f2c9;
    border-top: 2px solid #30940b;
    border-bottom: 2px solid #30940b;
    margin-left: 20px;
    margin-right: 20px;
    margin-bottom: 20px;
}

#supportreply p.client {
    padding-left: 10px;
    padding-bottom: 10px;
    padding-right: 10px;
    padding-top: 10px;
    display: block;
    background-color: #eaf6f7;
    border-top: 2px solid #acdbe1;
    border-bottom: 2px solid #acdbe1;
    background: #eaf6f7;;
    margin-left: 20px;
    margin-right: 20px;
    margin-bottom: 20px;
}

    /* STAFF SUPPORT PAGE COMPONENTS */

td.support-staff-open {
    background: #d8f2c9;
    font-weight: bold;
}

td.support-staff-closed {
    background: #dd8282;
    font-weight: bold;
}

td.support-actions {
    background: #dbeff2;
    width: 55px;
    border-left: 10px solid #fff;
}

td.support-actions img {
    margin-right: 10px;
}

    /* ACCOUNT MANAGEMENT */

h2 {
    font: bold 24px helvetica, arial, sans-serif;
    color: #fff;
    display: inline;
    margin-left: 10px;
}

fieldset {
    background-color: #eaf6f7;
    border-top: 2px solid #acdbe1;
    border-bottom: 2px solid #acdbe1;
    margin: 20px;
    padding: 20px;
    display: block;
    *position: relative;
    *margin-top: 20px;
    *padding-top: 40px;
}

legend {
    font: bold 16px helvetica, arial, sans-serif;
    padding: 5px;
    *position: absolute;
    *top: -.5em;
    *left: 20px;
    *padding: 0px;
    *margin-bottom: 20px;
}

label {
    float: left;
    text-align: right;
    width: 150px;
    font-weight: bold;
    margin-right: 10px;
    padding-top: 7px;
}

input {
    height: 20px;
    width: 300px;
    margin-bottom: 15px;
    padding: 3px;
    font: 16px 'Lucida Grande', arial, sans-serif;
}

.input_file {
    height: 25px;
    margin-bottom: 15px;
    padding: 3px;
    font: 16px 'Lucida Grande', arial, sans-serif;
}

select {
    height: 30px;
    width: 310px;
    margin-bottom: 15px;
    padding: 3px;
    font: 16px 'Lucida Grande', arial, sans-serif;
}

textarea {
    height: 140px;
    width: 400px;
    margin-bottom: 15px;
    padding: 3px;
    font: 16px 'Lucida Grande', arial, sans-serif;
}

.wysiwyg table {
    margin-bottom: 15px;
}

.wysiwyg td {
    border-bottom: 0px solid #fff;
    padding: 0px 0px 0px 0px;
    margin-bottom: 15px;
}

    /* BUTTONS */

.form button {
    display: block;
    float: left;
    margin: 0 7px 0 160px;
    background-color: #92c97c;
    border: 1px solid #73b35a;
    font-family: "Lucida Grande", Tahoma, Arial, Verdana, sans-serif;
    font-size: 100%;
    line-height: 130%;
    text-decoration: none;
    font-weight: bold;
    color: #e8f7df;
    cursor: pointer;
    padding: 5px 10px 6px 7px; /* Links */
    _margin-left: 82px;
}

.form button {
    width: auto;
    overflow: visible;
    padding: 4px 10px 3px 7px; /* IE6 */
}

.form button[type] {
    padding: 5px 10px 5px 7px; /* Firefox */
    line-height: 17px; /* Safari */
}

*:first-child+html button[type] {
    padding: 4px 10px 3px 7px; /* IE7 */
}

.form button img, .buttons a img {
    margin: 0 6px -3px 0 !important;
    padding: 0;
    border: none;
    width: 16px;
    height: 16px;
    text-decoration: none;
}

button:hover {
    background-color: #e8f7df;
    border: 1px solid #92c97c;
    color: #31940c;
}

.buttons a:active {
    background-color: #e8f7df;
    border: 1px solid #92c97c;
    color: #31940c;
}

    /* FOOTER */

#footer {
    width: 760px;
    padding: 20px;
    background-color: #104b67;
    color: #9fb7c2;
    font-weight: bold;
    margin-top: 20px;
}

#footer a {
    color: #9fb7c2;
    font-weight: normal;
}

    /* LOGIN */

body#login {
    width: 410px;
}

body#login #wrappertop {
    width: 370px;
}

body#login #wrapperbottom {
    width: 370px;
}

body#login #wrapperbottom_branding {
    width: 370px;
    padding: 0 20px 0 20px;
}

body#login #wrapperbottom_branding_text {
    width: 370px;
    background-color: #fff;
    padding-top: 3px;
    padding-bottom: 10px;
    color: #C0C0C0;
    font: 11px 'Lucida Grande', arial, sans-serif;
}

body#login #wrapperbottom_branding_text a {
    color: #C0C0C0;
}

body#login #wrapper {
    width: 370px;
    padding: 0 20px 0 20px;
}

body#login #content {
    width: 370px;
}

body#login #header {
    width: 350px;
}

body#login fieldset {
    width: 330px;
    border: 0;
    margin: 0px;
    display: block;
    margin-top: -30px;
    background-color: #fff;
    padding-top: 20px;
}

body#login fieldset p {
    color: #333333;
}

body#login fieldset p.error {
    padding: 10px 10px 10px 10px;
    color: #7b0c00;
    display: block;
    border: 2px solid #bc6f6b;
    background: #eac5c5;
    margin-bottom: 20px;
    font-weight: bold;
}

body#login fieldset p.error img {
    margin-right: 5px;
}

body#login label {
    float: left;
    text-align: right;
    width: 70px;
    font-weight: bold;
    margin-right: 10px;
    padding-top: 7px;
}

body#login input {
    height: 20px;
    width: 238px;
    _width: 237px;
    margin-bottom: 15px;
    padding: 3px;
    font: 16px 'Lucida Grande', arial, sans-serif;
}

body#login .form button {
    display: block;
    float: left;
    margin: 0 3px 0 80px;
    _margin-left: 42px;
}

#forgottenpassword {
    margin-top: 7px;
}

#forgottenpassword a {
    color: #333333;
}

#forgottenpassword a:hover {
    color: #104b67;
}

#forgottenpassword li {
    display: inline;
    margin-left: 10px;
}

    /* MESSAGE ALERTS */

#alert p {
    padding: 10px 10px 10px 10px;
    color: #7b0c00;
    display: block;
    border: 2px solid #bc6f6b;
    background: #eac5c5;
    margin-bottom: 20px;
    font-weight: bold;
}

#alert p img {
    margin-right: 5px;
}

#success p {
    padding: 10px 10px 10px 10px;
    color: #30940b;
    display: block;
    border: 2px solid #30940b;
    background: #d8f2c9;
    margin-bottom: 20px;
    font-weight: bold;
}

#success p img {
    margin-right: 5px;
}

    /* INSTALL MODULE*/

#install td {
    border-bottom: 0px solid #fff;
}

#install button {
    display: block;
    float: right;
    margin: 0 7px 0 160px;
    background-color: #92c97c;
    border: 1px solid #73b35a;
    font-family: "Lucida Grande", Tahoma, Arial, Verdana, sans-serif;
    font-size: 100%;
    line-height: 130%;
    text-decoration: none;
    font-weight: bold;
    color: #e8f7df;
    cursor: pointer;
    padding: 5px 10px 6px 7px; /* Links */
    _margin-left: 82px;
}

#install button {
    width: auto;
    overflow: visible;
    padding: 4px 10px 3px 7px; /* IE6 */
}

#install button[type] {
    padding: 5px 10px 5px 7px; /* Firefox */
    line-height: 17px; /* Safari */
}

*:first-child+html button[type] {
    padding: 4px 10px 3px 7px; /* IE7 */
}

#install button img, .buttons a img {
    margin: 0 6px -3px 0 !important;
    padding: 0;
    border: none;
    width: 16px;
    height: 16px;
    text-decoration: none;
}

button:hover {
    background-color: #e8f7df;
    border: 1px solid #92c97c;
    color: #31940c;
}

.buttons a:active {
    background-color: #e8f7df;
    border: 1px solid #92c97c;
    color: #31940c;
}

    /* STAFF GRAPHS */
#vertgraph {
    width: 378px;
    height: 207px;
    position: relative;
    background: url("../images/g_backbar.gif") no-repeat;
}

#vertgraph ul {
    width: 378px;
    height: 207px;
    margin: 0;
    padding: 0;
}

#vertgraph ul li {
    position: absolute;
    width: 28px;
    height: 160px;
    bottom: 34px;
    padding: 0 !important;
    margin: 0 !important;
    background: url("../images/g_colorbar3.jpg") no-repeat !important;
    text-align: center;
    font-weight: bold;
    color: white;
    line-height: 2.5em;
}

#vertgraph li.total {
    left: 24px;
    background-position: 0px bottom !important;
}

#vertgraph li.notstarted {
    left: 101px;
    background-position: -28px bottom !important;
}

#vertgraph li.inprogress {
    left: 176px;
    background-position: -56px bottom !important;
}

#vertgraph li.inreview {
    left: 251px;
    background-position: -84px bottom !important;
}

#vertgraph li.completed {
    left: 327px;
    background-position: -112px bottom !important;
}

    /* STAFF NAVIGATION  */

#dropmenudiv {
    padding-bottom: 5px;
    padding-top: 5px;
    border-left-width: 1px;
    border-right-width: 1px;
    border-top-width: 0px;
    border-style: solid;
    border-color: white;
    position: absolute;
    border-bottom-width: 1px;
    font: normal 12px "Arial";
    line-height: 15px;
    color: white;
    z-index: 100;
    text-align: left;

}

#dropmenudiv .navcat {
    margin-left: 5px;
}

#dropmenudiv a {
    padding-left: 0px;
    padding-bottom: 2px;
    padding-right: 0px;
    padding-top: 2px;
    font: normal 11px Arial;
    border-bottom-width: 0px;
    width: 100%;
    display: block;
    text-indent: 10px;
    text-decoration: none;
    color: #504f4f;
    font-family: "Lucida Sans";
    line-height: 15px;

}

#dropmenudiv a:hover {
    /*hover background color*/
    color: white;
    background-color: #5e5d5d;
}

p {
    font-size: 20px;
}

h3 {
    font-size: 30px;
}

</style>
</head>
<body id="login">
<div id="wrappertop"></div>
<div id="wrapper">
    <div id="content">
        <div id="header">
        </div>
        <div id="darkbanner" class="banner320">
            <h2>Billings for "${user.getName()}"</h2>
        </div>
        <div id="darkbannerwrap">
        </div>
                <p>
                    Your bills:

                <div style="text-align: center;">

                    <table border=1>
                    <tr>
                    	<th>Bill id</th>
                    	<th>Username</th>
                    	<th>is payed</th>
                    	<th>amount</th>
                    </tr>
                    <c:forEach var="bill" items="${bills}">
                    	<tr>
                    		<td>${bill.id }</td>
                    		<td>${bill.customerUsername }</td>
                    		<td>${bill.payed}</td>
                    		<td>${bill.amount }</td>
                    	</tr>
                    
                    </c:forEach>
                    
                    </table>
                </div>

                </p>
        <button type="button" class="positive" name="back" onclick="window.location='<%=request.getContextPath()%>/Overview';">
            Overview
        </button>
        <button type="button" class="positive" name="logout" onclick="window.location='<%=request.getContextPath()%>/Pay';">
            Pay open Bills
        </button>
    </div>
</div>
</body>
</html>