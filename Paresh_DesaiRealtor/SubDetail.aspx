<%@ Page Title="" Language="C#" MasterPageFile="~/Property.Master" AutoEventWireup="true" CodeBehind="SubDetail.aspx.cs" Inherits="Property.SubDetail" %>

<%@ OutputCache Duration="15" VaryByParam="None" %>
<asp:Content ID="Content3" ContentPlaceHolderID="HeadContent" runat="server">

    <link href="slider/css/media-queries.css" rel="stylesheet" />
    <link href="slider/css/font.css" rel="stylesheet" />
    <link href="slider/css/style.css" rel="stylesheet" />


    <script src="slider/js/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="slider/js/jquery-1.9.1.min.js"></script>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12 col-sm-12 margin_0">
        <div>
            <div class="main_contnt_sct">
                <div class="Residential_section_bg" id="divresidential" runat="server" >

                    <div class="col-md-12 col-sm-12">
                        <div class="Residential_section">
                            <h3>Search by Categories</h3>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-4">
                        <div id="div1" class="" runat="server">
                            <div class="Residential_section_box">
                              
                                    <asp:HyperLink ID="hlresi1" runat="server">
                                <asp:Label ID="resicity1" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                               
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-4">
                        <div id="div2" class="" runat="server">
                            <div class="Residential_section_box">
                               
                                    <asp:HyperLink ID="hlresi2" runat="server">
                            <asp:Label ID="resicity2" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                               
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4 col-sm-4">
                        <div id="div3" runat="server" class="">
                            <div class="Residential_section_box">
                               
                                    <asp:HyperLink ID="hlresi3" runat="server">
                            <asp:Label ID="resicity3" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                               
                            </div>
                        </div>
                    </div>
                   
                </div>
              
            </div>
        </div>
    </div>
</asp:Content>
