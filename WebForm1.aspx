<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Module2Topic1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home page</h1>
    <h3>Question 1.</h3>
    <p>I see vanilla HTML as laying the groundwork for ASP.NET. Without a solid foundation in website creation through HTML, comprehending the intricacies 
    of ASP.NET becomes challenging. This is because ASP.NET is intricately linked to and heavily relies on fundamental HTML principles and concepts.
    </p>
    <br />
    <h3>Question 2</h3>
    <p>In my perspective, employing both inline scripting and code-behind serves specific purposes. However, I generally favor the practice of keeping the
    code-behind separate from the front-end. This approach offers advantages such as streamlined debugging processes, efficient delegation of functions, 
    and enhanced overall maintainability. While JavaScript proves valuable, particularly in debugging scenarios, maintaining a distinction between server-side 
    and client-side code remains my preference.
    </p>
    <br />
    <h3>Question 3</h3>
    <p>A postback denotes the procedural sequence in which a web page is transmitted back to the server for further processing. 
    This event takes place when a user engages with a web page, such as clicking a button or initiating an action that necessitates server-side 
    processing. In essence, a postback is the mechanism through which interactive actions trigger the exchange of data between the user's browser 
    and the server, facilitating dynamic updates and server-driven functionalities within the web application.</p>
</asp:Content>
