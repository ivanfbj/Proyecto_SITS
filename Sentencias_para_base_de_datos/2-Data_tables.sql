GO
SET IDENTITY_INSERT [dbo].[tblTipoMovimiento] ON 

INSERT [dbo].[tblTipoMovimiento] ([Id], [descripcion]) VALUES (3, N'Averia')
INSERT [dbo].[tblTipoMovimiento] ([Id], [descripcion]) VALUES (4, N'Consumo Personal')
INSERT [dbo].[tblTipoMovimiento] ([Id], [descripcion]) VALUES (1, N'Entrada')
INSERT [dbo].[tblTipoMovimiento] ([Id], [descripcion]) VALUES (5, N'Otro')
INSERT [dbo].[tblTipoMovimiento] ([Id], [descripcion]) VALUES (2, N'Salida')
SET IDENTITY_INSERT [dbo].[tblTipoMovimiento] OFF
GO


/*************************************************************************/

SET IDENTITY_INSERT [dbo].[tblCombo] ON 
GO
INSERT [dbo].[tblCombo] ([id], [nroCombo], [nombre], [subtotal]) VALUES (1, 1, N'Combo 1', 7000)
INSERT [dbo].[tblCombo] ([id], [nroCombo], [nombre], [subtotal]) VALUES (2, 2, N'Combo 2', 7900)
INSERT [dbo].[tblCombo] ([id], [nroCombo], [nombre], [subtotal]) VALUES (3, 3, N'Combo 3', 5700)
INSERT [dbo].[tblCombo] ([id], [nroCombo], [nombre], [subtotal]) VALUES (4, 4, N'Combo 4', 12000)
SET IDENTITY_INSERT [dbo].[tblCombo] OFF
GO
SET IDENTITY_INSERT [dbo].[tblProductoxCombo] ON 
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (1, 1, 1, 1)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (2, 1, 2, 1)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (3, 2, 3, 1)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (4, 2, 4, 1)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (5, 2, 5, 1)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (6, 3, 6, 1)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (7, 3, 7, 1)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (8, 3, 8, 1)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (9, 4, 23, 3)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (10, 4, 24, 3)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (11, 4, 25, 3)
INSERT [dbo].[tblProductoxCombo] ([id], [combo_id], [producto_id], [cantidad]) VALUES (12, 4, 26, 3)
SET IDENTITY_INSERT [dbo].[tblProductoxCombo] OFF

