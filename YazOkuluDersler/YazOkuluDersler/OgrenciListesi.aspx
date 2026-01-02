<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciListesi.aspx.cs" Inherits="OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2"
    runat="Server">
    <table class="table table-bordered table-hover" style="background-color: #CCCCCC">
        <tr>
            <th>Öğrenci ID</th>
            <th>Öğrenci Ad</th>
            <th>Öğrenci Soyad</th>
            <th>Öğrenci Numara</th>
            <th>Öğrenci Şifre</th>
            <th>Öğrenci Fotoğraf</th>
            <th>Bakiye</th>
            <th>İşlemler</th>

        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>

                    <tr>
                        <td><%# Eval("Id")%></td>
                        <td><%# Eval("Ad")%></td>
                        <td><%# Eval("Soyad")%></td>
                        <td><%# Eval("Numara")%></td>
                        <td><%# Eval("Sifre")%></td>
                        <td style="text-align: center;">
                            <img src='<%# "Images/" + Eval("Fotograf") %>'
                                width="45" height="45"
                                style="border-radius: 50%; object-fit: cover; border: 2px solid #5bc0de;"
                                onerror="this.src='Images/man.jpg';" />
                        </td>
                        <td><%# Eval("Bakiye")%></td>
                        <td>
                            <asp:HyperLink
                                NavigateUrl='<%# "~/OgrenciSil.aspx?OGRID=" + Eval("Id") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>

                            <asp:HyperLink
                                NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OGRID=" + Eval("Id") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Güncelle</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>
</asp:Content>

