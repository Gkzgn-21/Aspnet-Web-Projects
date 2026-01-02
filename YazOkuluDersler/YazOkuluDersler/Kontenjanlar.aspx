<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kontenjanlar.aspx.cs" Inherits="Kontenjanlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <div style="margin: 20px;">
        <h2><strong>Ders Kontenjan Durumları</strong></h2>
        <table class="table table-bordered table-hover" style="background-color: #CCCCCC">
            <thead class="thead-dark">
                <tr>
                    <th>Ders Adı</th>
                    <th>Toplam Kontenjan</th>
                    <th>Kayıtlı Öğrenci</th>
                    <th>Kalan Yer</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("DERSAD") %></td>
                            <td><%# Eval("MAX") %></td>
                            <td><%# Eval("DERSKAYITLISAYISI") %></td>
                            <td>
                                <span class="badge badge-info" style="font-size: 14px;">
                                    <%# Convert.ToInt32(Eval("MAX")) - Convert.ToInt32(Eval("DERSKAYITLISAYISI")) %>
                                </span>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>

