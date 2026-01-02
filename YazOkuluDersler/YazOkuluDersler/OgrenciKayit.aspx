<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciKayit.aspx.cs" Inherits="OgrenciKayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group" enctype="multipart/form-data">
            <h3 style="margin-top: 20px;"><strong>Yeni Öğrenci Kayıt Formu</strong></h3>
            <hr />
            <div>
                <strong>
                    <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control" Style="background-color: #CCCCCC"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control" Style="background-color: #CCCCCC"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numara:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control" Style="background-color: #CCCCCC"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control" Style="background-color: #CCCCCC"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="FileUpload1" runat="server" Text="Öğrenci Fotoğraf Seç:"></asp:Label>
                </strong>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />
    </form>
</asp:Content>

