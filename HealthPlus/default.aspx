<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HealthPlus.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
   
    <section>
        <div class="container ">                    
                        <center>
                            <h2>Health Plus</h2>
                            <p><b>Let Us care for You so that you don't have to </b></p>      
                            <div class ="row">
                                <div class="col-md-3">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button6" runat="server" Text="Hospitals" OnClick="Button6_Click" />
                                </div>
                                 <div class="col-md-3">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Health Schemes" OnClick="Button1_Click" />
                                </div>
                                 <div class="col-md-3">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button2" runat="server" Text="Buy Medicines" OnClick="Button2_Click" />
                                </div>
                                 <div class="col-md-3">
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button3" runat="server" Text="Medical History" OnClick="Button3_Click" />
                                </div>

                            </div>
                        </center>  
        </div>
    </section>
    <section>       
       <center>        
                <img width="100%" src="imgs/Doctorcover.jpg" />            
       </center>      
   </section>

</asp:Content>
