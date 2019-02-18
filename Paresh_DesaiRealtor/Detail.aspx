<%@ Page Title="" Language="C#" MasterPageFile="~/Property.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="Property.Detail" %>

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
                            <h3>Search by Cities</h3>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div1" class="" runat="server">
                            <div class="Residential_section_box">
                              
                                    <asp:HyperLink ID="hlresi1" runat="server">
                                <asp:Label ID="resicity1" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                               
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm -3">
                        <div id="div2" class="" runat="server">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Mississauga" title="">
                                    <asp:HyperLink ID="hlresi2" runat="server">
                            <asp:Label ID="resicity2" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div3" runat="server" class="">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Brampton" title="">
                                    <asp:HyperLink ID="hlresi3" runat="server">
                            <asp:Label ID="resicity3" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div4" runat="server" class="">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Markham" title="">
                                    <asp:HyperLink ID="hlresi4" runat="server">
                            <asp:Label ID="resicity4" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="Residential_section_bg" runat="server">



                    <div class="col-md-3 col-sm-3">
                        <div id="div5" runat="server" class="">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Mississauga" title="">
                                    <asp:HyperLink ID="hlresi5" runat="server">
                           <asp:Label ID="resicity5" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                    
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div6" runat="server" class="">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Brampton" title="">
                                    <asp:HyperLink ID="hlresi6" runat="server">
                           <asp:Label ID="resicity6" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                    
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div7" runat="server" class="">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Markham" title="">
                                    <asp:HyperLink ID="hlresi7" runat="server">
                           <asp:Label ID="resicity7" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                    
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div8" runat="server" class="">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Toronto" title="">
                                    <asp:HyperLink ID="hlresi8" runat="server">
                                <asp:Label ID="resicity8" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                                <div class="Residential_section_bg" runat="server" >

                
                    <div class="col-md-3 col-sm-3">
                        <div id="div10" class="" runat="server" visible="false">
                            <div class="Residential_section_box">
                              
                                    <asp:HyperLink ID="HyperLink1" runat="server">
                                 <asp:Label ID="Label1" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                  
                               
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm -3">
                        <div id="div11" class="" runat="server" visible="false">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Mississauga" title="Mississauga">
                                    <asp:HyperLink ID="HyperLink2" runat="server">
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div12" runat="server" class="" visible="false">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Brampton" title="">
                                    <asp:HyperLink ID="HyperLink3" runat="server">
                           <asp:Label ID="Label3" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                    
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div13" runat="server" class="" visible="false">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Markham" title="Markham">
                                    <asp:HyperLink ID="HyperLink4" runat="server">
                            <asp:Label ID="Label4" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                                </a>
                            </div>
                        </div>
                    </div>
                </div>

                                <div class="Residential_section_bg" id="div9" runat="server" >

                    <div class="col-md-12 col-sm-12">
                       
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div14" class="" runat="server" visible="false">
                            <div class="Residential_section_box">
                              
                                    <asp:HyperLink ID="HyperLink5" runat="server">
                                <asp:Label ID="Label5" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                               
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm -3">
                        <div id="div15" class="" runat="server" visible="false">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Mississauga" title="Mississauga">
                                    <asp:HyperLink ID="HyperLink6" runat="server">
                           <asp:Label ID="Label6" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                    
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div16" runat="server" class="" visible="false">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Brampton" title="Brampton">
                                    <asp:HyperLink ID="HyperLink7" runat="server">
                           <asp:Label ID="Label7" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                    
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div17" runat="server" class="" visible="false">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Markham" title="Markham">
                                    <asp:HyperLink ID="HyperLink8" runat="server">
                            <asp:Label ID="Label8" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                                <div class="Residential_section_bg" id="div18" runat="server" >

                   
                    <div class="col-md-3 col-sm-3">
                        <div id="div19" class="" runat="server" visible="false">
                            <div class="Residential_section_box">
                              
                                    <asp:HyperLink ID="HyperLink9" runat="server">
                               <asp:Label ID="Label9" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                    
                               
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm -3">
                        <div id="div20" class="" runat="server" visible="false">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Mississauga" title="Mississauga">
                                    <asp:HyperLink ID="HyperLink10" runat="server">
                            <asp:Label ID="Label10" runat="server"></asp:Label>
                                    </asp:HyperLink>
                                   
                                </a>
                            </div>
                        </div>
                    </div>
                 <%--   <div class="col-md-3 col-sm-3">
                        <div id="div21" runat="server" class="">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Brampton" title="Brampton">
                                    <asp:HyperLink ID="HyperLink11" runat="server">
                           
                                    </asp:HyperLink>
                                    <asp:Label ID="Label11" runat="server"></asp:Label>
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-3">
                        <div id="div22" runat="server" class="">
                            <div class="Residential_section_box">
                                <a href="../Search.aspx?Municipality=Markham" title="Markham">
                                    <asp:HyperLink ID="HyperLink12" runat="server">
                           
                                    </asp:HyperLink>
                                    <asp:Label ID="Label12" runat="server"></asp:Label>
                                </a>
                            </div>
                        </div>
                    </div>--%>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
