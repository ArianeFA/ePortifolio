SET IDENTITY_INSERT [dbo].[TableOne] ON
INSERT INTO [dbo].[TableOne] ([Id], [RoomNumber], [RoomDescription], [RoomVacancy]) VALUES (1, N'101', N'1 King Bed', N'Occupied')
INSERT INTO [dbo].[TableOne] ([Id], [RoomNumber], [RoomDescription], [RoomVacancy]) VALUES (2, N'102', N'2 Twin Beds and 1 King Bed', N'Vacant')
INSERT INTO [dbo].[TableOne] ([Id], [RoomNumber], [RoomDescription], [RoomVacancy]) VALUES (1002, N'103', N'2 Queen Beds', N'Occupied')
INSERT INTO [dbo].[TableOne] ([Id], [RoomNumber], [RoomDescription], [RoomVacancy]) VALUES (1003, N'104', N'1 Sofa Ded and 2 Queen Beds', N'Occupied')
INSERT INTO [dbo].[TableOne] ([Id], [RoomNumber], [RoomDescription], [RoomVacancy]) VALUES (1004, N'105', N'1 Sofa Bed and 1 King Bed', N'Occupied')
INSERT INTO [dbo].[TableOne] ([Id], [RoomNumber], [RoomDescription], [RoomVacancy]) VALUES (1005, N'106', N'3 Twin Beds', N'Vacant')
INSERT INTO [dbo].[TableOne] ([Id], [RoomNumber], [RoomDescription], [RoomVacancy]) VALUES (1006, N'107', N'2 King Beds', N'Vacant')
SET IDENTITY_INSERT [dbo].[TableOne] OFF
