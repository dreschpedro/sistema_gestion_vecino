Partial Class reporte_principal

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reporte_principal))
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.DetailSection1 = New Telerik.Reporting.DetailSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.vecino_sustentable = New Telerik.Reporting.SqlDataSource()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.PageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.PageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TextBox1
        '
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.226R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox1.StyleName = "BlueOpal.TableHeader"
        Me.TextBox1.Value = "Ecopunto"
        '
        'TextBox2
        '
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.934R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox2.StyleName = "BlueOpal.TableHeader"
        Me.TextBox2.Value = "Residuo"
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.04R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox3.StyleName = "BlueOpal.TableHeader"
        Me.TextBox3.Value = "Cantidad"
        '
        'DetailSection1
        '
        Me.DetailSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(9.4R)
        Me.DetailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.DetailSection1.Name = "DetailSection1"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.226R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.934R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.04R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.5R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox4)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox5)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox6)
        TableGroup1.Name = "residuo"
        TableGroup1.ReportItem = Me.TextBox1
        TableGroup2.Name = "ecopunto"
        TableGroup2.ReportItem = Me.TextBox2
        TableGroup3.Name = "cantidad"
        TableGroup3.ReportItem = Me.TextBox3
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.DataSource = Me.vecino_sustentable
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox1, Me.TextBox2, Me.TextBox3})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.4R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Table1.Name = "Table1"
        TableGroup4.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup4.Name = "detail"
        Me.Table1.RowGroups.Add(TableGroup4)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.2R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.Table1.StyleName = "BlueOpal.TableNormal"
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.226R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox4.StyleName = "BlueOpal.TableBody"
        Me.TextBox4.Value = "= Fields.Ecopunto"
        '
        'TextBox5
        '
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.934R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox5.StyleName = "BlueOpal.TableBody"
        Me.TextBox5.Value = "= Fields.Residuo"
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.04R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox6.StyleName = "BlueOpal.TableBody"
        Me.TextBox6.Value = "= Fields.Cantidad"
        '
        'vecino_sustentable
        '
        Me.vecino_sustentable.ConnectionString = "vecinoSustentableApp.My.MySettings.VS_DB"
        Me.vecino_sustentable.Name = "vecino_sustentable"
        Me.vecino_sustentable.SelectCommand = resources.GetString("vecino_sustentable.SelectCommand")
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.0R), Telerik.Reporting.Drawing.Unit.Cm(0.9R))
        Me.TextBox7.Name = "ReportNameTextBox"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.0R), Telerik.Reporting.Drawing.Unit.Cm(0.8R))
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Segoe UI"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox7.Value = "Reporte de Ingresos de Residuos Hoy"
        '
        'PageHeaderSection1
        '
        Me.PageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5R)
        Me.PageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox7})
        Me.PageHeaderSection1.Name = "PageHeaderSection1"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.3R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox8.Name = "ReportPageNumberTextBox"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.7R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox8.Style.Font.Name = "Segoe UI"
        Me.TextBox8.Value = "P�gina: {PageNumber}"
        '
        'PageFooterSection1
        '
        Me.PageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.PageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox8})
        Me.PageFooterSection1.Name = "PageFooterSection1"
        '
        'reporte_principal
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.DetailSection1, Me.PageHeaderSection1, Me.PageFooterSection1})
        Me.Name = "Report1"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "BlueOpal.TableNormal")})
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(89, Byte), Integer))
        StyleRule2.Style.Font.Name = "Segoe UI"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "BlueOpal.TableBody")})
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(89, Byte), Integer))
        StyleRule3.Style.Font.Name = "Segoe UI"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "BlueOpal.TableHeader")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(249, Byte), Integer))
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer))
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(89, Byte), Integer))
        StyleRule4.Style.Font.Name = "Segoe UI"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(17.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents DetailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents vecino_sustentable As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents PageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents PageFooterSection1 As Telerik.Reporting.PageFooterSection
End Class