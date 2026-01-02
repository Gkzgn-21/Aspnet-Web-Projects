<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
   <div class="container-fluid" style="margin-top: 15px;">
        <div class="row">
            <div class="col-md-4">
                <div class="alert alert-info text-center">
                    <strong>Toplam Öğrenci: </strong> 
                    <asp:Label ID="lblOgr" runat="server" Text="0" Font-Bold="true" Font-Size="Large"></asp:Label>
                </div>
            </div>
            <div class="col-md-4">
                <div class="alert alert-success text-center">
                    <strong>Toplam Ders: </strong> 
                    <asp:Label ID="lblDers" runat="server" Text="0" Font-Bold="true" Font-Size="Large"></asp:Label>
                </div>
            </div>
            <div class="col-md-4">
                <div class="alert alert-warning text-center">
                    <strong>Toplam Başvuru: </strong> 
                    <asp:Label ID="lblBasvuru" runat="server" Text="0" Font-Bold="true" Font-Size="Large"></asp:Label>
                </div>
            </div>
        </div>
       <div class="row" style="margin-top: 20px;">
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-default" style="border-radius:15px; box-shadow: 0 4px 12px rgba(0,0,0,0.15);">
                    <div class="panel-heading" style="background-color:#f5f5f5; font-weight:bold; text-align:center;">Ders Başvuru Dağılımı</div>
                    <div class="panel-body">
                        <canvas id="myChart" style="max-height:300px;"></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
    <script>
        document.addEventListener("DOMContentLoaded", function () {
            const ctx = document.getElementById('myChart').getContext('2d');
            new Chart(ctx, {
                type: 'pie',
                data: {
                    labels: [<%= dersAdlari %>], // C# tarafından beslenir
                    datasets: [{
                        data: [<%= dersBasvuruSayilari %>], // C# tarafından beslenir
                        backgroundColor: ['#3498db', '#2ecc71', '#f1c40f', '#e74c3c', '#9b59b6', '#34495e'],
                        hoverOffset: 10
                    }]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false
                }
            });
        });
    </script>
</asp:Content>

