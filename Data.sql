USE [DiamondStore]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Nhẫn')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Dây chuyền')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Mặt dây chuyền')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Vòng tay')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[JewelrySetting] ON 

INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (1, N'Vàng trắng 14K ', 3400000)
INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (2, N'Vàng 18K', 5000000)
INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (4, N'Bạc', 500000)
INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (5, N'Vàng trắng 10K ', 2900000)
INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (6, N'Vàng 14K', 3000000)
INSERT [dbo].[JewelrySetting] ([JewelrySettingID], [Material], [BasePrice]) VALUES (7, N'Vàng trắng 18K ', 4500000)
SET IDENTITY_INSERT [dbo].[JewelrySetting] OFF
GO
SET IDENTITY_INSERT [dbo].[MainDiamonds] ON 

INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (1, N'Đá CZ ', 2000000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (2, N'Đá SYN.RUB', 7500000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (3, N'Đá SYN.SAP', 8000000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (5, N'Đá CZ 2.5', 3000000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (6, N'Không ', 0)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (7, N'Đá CZ 3.0', 3500000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (8, N'Đá CZ 3.5', 4200000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (9, N'Đá CZ 4.0', 4800000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (10, N'Đá CZ 4.5', 5000000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (11, N'Đá CZ 5.0', 5700000)
INSERT [dbo].[MainDiamonds] ([MainDiamondID], [MainDiamondName], [Price]) VALUES (12, N'Đá CZ 5.5', 6000000)
SET IDENTITY_INSERT [dbo].[MainDiamonds] OFF
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-001', N'Dây chuyền Vàng Trắng Ý 18K - Elegance Radiance', N'Jewelry', N'Thiết kế tinh tế: Dây chuyền Elegance Radiance mang đến vẻ đẹp tinh tế và sang trọng với kiểu dáng hiện đại, tôn lên sự thanh lịch của người đeo.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, có độ bóng sáng và bền bỉ, mang lại vẻ ngoài đẳng cấp và quý phái.', CAST(1.00 AS Decimal(18, 2)), 15600000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-002', N'Dây chuyền Vàng Trắng Ý 18K - Classic Grace', N'Jewelry', N'Thiết kế thanh lịch: Dây chuyền Classic Grace mang phong cách cổ điển với thiết kế tinh xảo, tôn lên vẻ đẹp trang nhã và thanh lịch của người đeo.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, có độ sáng bóng và bền bỉ, mang lại vẻ ngoài sang trọng và đẳng cấp.
Phong cách cổ điển: Dây chuyền Classic Grace phù hợp cho những ai yêu thích phong cách cổ điển, trang nhã, dễ dàng kết hợp với nhiều trang phục và phong cách khác nhau.
Chi tiết tinh xảo: Các chi tiết của dây chuyền được gia công tỉ mỉ, mang đến sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 12200000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-003', N'Dây chuyền Vàng Trắng Ý 18K - Pure Elegance', N'Jewelry', N'Thiết kế tinh tế: Dây chuyền Pure Elegance mang đến vẻ đẹp tinh tế và sang trọng với kiểu dáng hiện đại, phù hợp với mọi phong cách thời trang.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, với độ bóng sáng hoàn hảo, đảm bảo sự bền bỉ và đẳng cấp cho người đeo.
Phong cách thời trang: Dây chuyền Pure Elegance phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện đặc biệt, giúp bạn luôn tự tin và nổi bật.
Độ dài hoàn hảo: Độ dài dây chuyền được thiết kế vừa vặn, dễ dàng kết hợp với nhiều loại trang phục và phong cách khác nhau.
Gia công tinh xảo: Mỗi chi tiết của dây chuyền được gia công tỉ mỉ, mang đến sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 11900000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-004', N'Dây chuyền Vàng Ý 18K - Eternal Shine', N'Jewelry', N'Thiết kế đẳng cấp: Dây chuyền Eternal Shine mang vẻ đẹp đẳng cấp và sang trọng với thiết kế tinh xảo, tôn lên sự quý phái và phong cách của người đeo.
Vàng Ý 18K: Chất liệu vàng Ý 18K cao cấp, nổi tiếng với độ bóng sáng và độ bền vượt trội, đảm bảo vẻ đẹp lâu dài và giá trị của sản phẩm.
Món quà ý nghĩa: Dây chuyền Eternal Shine là món quà hoàn hảo dành cho người thân, bạn bè hoặc đối tác, thể hiện sự trân trọng và tình cảm chân thành.
Dễ dàng bảo quản: Với chất liệu vàng Ý 18K, dây chuyền không chỉ bền bỉ theo thời gian mà còn dễ dàng bảo quản và làm sạch, luôn giữ được vẻ đẹp ban đầu.', CAST(1.00 AS Decimal(18, 2)), 12700000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-005', N'Dây chuyền Vàng Trắng 10K - Radiant Charm', N'Jewelry', N'Thiết kế hiện đại: Dây chuyền Radiant Charm mang vẻ đẹp hiện đại và tinh tế, thiết kế đơn giản nhưng không kém phần sang trọng, phù hợp với nhiều phong cách thời trang.
Vàng Trắng 10K: Chất liệu vàng trắng 10K cao cấp, có độ bóng sáng hoàn hảo và bền bỉ, mang lại vẻ ngoài quý phái và đẳng cấp.
Phong cách thời trang: Dây chuyền Radiant Charm phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện đặc biệt, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của dây chuyền được gia công tỉ mỉ, mang đến sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 2200000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-006', N'Dây chuyền Vàng 14K - Golden Elegance', N'Jewelry', N'Thiết kế sang trọng: Dây chuyền Golden Elegance sở hữu thiết kế thanh lịch và tinh tế, phù hợp với nhiều phong cách thời trang và dễ dàng kết hợp với các loại trang sức khác.
Vàng 14K: Chất liệu vàng 14K cao cấp, có độ sáng bóng tự nhiên và bền bỉ, mang lại vẻ ngoài đẳng cấp và quý phái.
Phong cách thời trang: Dây chuyền Golden Elegance phù hợp cho nhiều dịp, từ công sở, dạo phố đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.', CAST(1.00 AS Decimal(18, 2)), 15300000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-007', N'Dây chuyền Vàng Trắng Ý 18K - Eternal Sparkle', N'Jewelry', N'Thiết kế sang trọng: Dây chuyền Eternal Sparkle sở hữu thiết kế thanh lịch và tinh tế, tôn lên vẻ đẹp hiện đại và đẳng cấp của người đeo.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, có độ sáng bóng hoàn hảo và bền bỉ, mang lại vẻ ngoài quý phái và tinh tế.
Gia công tinh xảo: Mỗi chi tiết của dây chuyền được gia công tỉ mỉ bởi những nghệ nhân lành nghề, mang đến sản phẩm hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 39400000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-008', N'Dây chuyền Vàng Trắng Ý 18K - Radiant Elegance', N'Jewelry', N'Thiết kế thanh lịch: Dây chuyền Radiant Elegance được thiết kế với phong cách tinh tế và hiện đại, mang lại vẻ đẹp thanh lịch và quý phái cho người đeo.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, nổi bật với độ sáng bóng tự nhiên và độ bền cao, đảm bảo vẻ đẹp lâu dài và giá trị của sản phẩm.
Phong cách thời trang: Dây chuyền Radiant Elegance phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.', CAST(1.00 AS Decimal(18, 2)), 11500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-001', N'Kim cương viên GIA 3.6ly D VS2 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 14095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-002', N'Kim cương viên GIA 3.6ly E VS2 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 13500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-003', N'Kim cương viên GIA 3.6ly E VS1 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 14500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-004', N'Kim cương viên GIA 3.6ly F VS1 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 14000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-005', N'Kim cương viên GIA 3.6ly E VVS2 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 15500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-006', N'Kim cương viên GIA 3.6ly E VVS1 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 16500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-007', N'Kim cương viên GIA 3.6ly E VVS1 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 16500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-008', N'Kim cương viên GIA 3.6ly D IF EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 18095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-001', N'Kim cương viên GIA 4.1ly E VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 24500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-002', N'Kim cương viên GIA 4.1ly E VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 24500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-003', N'Kim cương viên GIA 4.1ly E VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 24500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-004', N'Kim cương viên GIA 4.1ly E VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 23500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-005', N'Kim cương viên GIA 4.1ly E VVS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 25500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-006', N'Kim cương viên GIA 4.1ly F VVS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 25000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-007', N'Kim cương viên GIA 4.1ly F VVS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 25000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-008', N'Kim cương viên GIA 4.1ly F VVS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 26000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-001', N'Kim cương viên GIA 4.5ly D VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 34095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-002', N'Kim cương viên GIA 4.5ly D VS2 EX ', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 34095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-003', N'Kim cương viên GIA 4.5ly E IF EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 37500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-004', N'Kim cương viên GIA 4.5ly E VVS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 36500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-005', N'Kim cương viên GIA 4.5ly D VVS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 36095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-006', N'Kim cương viên GIA 4.5ly D VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 35095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-007', N'Kim cương viên GIA 4.5ly E IF EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 37500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-008', N'Kim cương viên GIA 4.5ly D VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 35095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-001', N'Kim cương viên GIA 5.4ly D VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 44095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-002', N'Kim cương viên GIA 5.4ly D VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 45095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-003', N'Kim cương viên GIA 5.4ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 43000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-004', N'Kim cương viên GIA 5.4ly E VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 43500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-005', N'Kim cương viên GIA 5.4ly E VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 43500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-006', N'Kim cương viên GIA 5.4ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 43000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-007', N'Kim cương viên GIA 5.4ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 43000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-008', N'Kim cương viên GIA 5.4ly D VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 45095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-001', N'Mặt kim cương tấm vàng 14K Amuse N 2C', N'Jewelry', N'Kim cương tấm rực rỡ: Mặt kim cương được gắn những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh và rực rỡ, thu hút mọi ánh nhìn.
Phong cách thời trang: Mặt kim cương Amuse N 2C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, mang đến sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 8000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-002', N'Mặt kim cương tấm vàng 14K Accius B 2C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương được gắn những viên kim cương tấm nhỏ, mang lại vẻ lấp lánh rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Accius B 2C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 9100000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-003', N'Mặt kim cương tấm vàng 14K Adiva 1CT', N'Jewelry', N'Kim cương 1 carat: Mặt kim cương Adiva nổi bật với viên kim cương chính có trọng lượng 1 carat, mang lại vẻ lấp lánh rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Adiva 1CT phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 13400000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-004', N'Mặt kim cương tấm vàng 14K Arlana N 5C', N'Jewelry', N'Kim cương tấm rực rỡ: Mặt kim cương được gắn với những viên kim cương tấm nhỏ, tạo nên sự lấp lánh và rực rỡ, thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Arlana N 5C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.
', CAST(1.00 AS Decimal(18, 2)), 30000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-005', N'Mặt kim cương tấm vàng 14K Fetchingly N 3C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương được gắn những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh rực rỡ, thu hút mọi ánh nhìn.
Phong cách thời trang: Mặt kim cương Fetchingly N 3C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 16900000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-006', N'Mặt kim cương tấm vàng 14K Flaring 2C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương được gắn với những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh rực rỡ, thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Flaring 2C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 11800000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-007', N'Mặt kim cương tấm vàng 14K Firming 3C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương được gắn với những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh rực rỡ, thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Firming 3C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 28200000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-008', N'Mặt kim cương tấm vàng 14K Florid 3C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương Florid 3C được gắn những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh rực rỡ, thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Florid 3C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 17000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-001', N'Nhẫn đính đá CZ vàng 10K Barony N W', N'Jewelry', N'Sở hữu dáng nhẫn mạnh mẽ, cứng cáp, nhẫn Barony gây ấn tượng với Phái mạnh với thiết kế 9 viên đá ở trung tâm mặt nhẫn và những viên tấm hai bên đai nhẫn được sắp xếp tỉ mỉ thằng tắp với một tỉ lệ hoàn hảo. Barony là một lựa chọn lý tưởng giúp Phái mạnh khẳng định phong cách trong mọi hoàn cảnh.', CAST(1.00 AS Decimal(18, 2)), 16500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-002', N'Nhẫn đính đá CZ vàng 10K Authentic', N'Jewelry', N'Authentic với thiết kế đặc biệt kết hợp giữa hai loại vàng trắng và vàng vàng, tạo nên phong cách mạnh mẽ, nam tính và sang trọng. Được chế tác tinh xảo đến từng chi tiết và linh động theo nhu cầu', CAST(1.00 AS Decimal(18, 2)), 17350000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-003', N'Nhẫn nam đính đá CZ vàng 10K Creator 5C', N'Jewelry', N'Một sản phẩm tinh xảo, kết hợp giữa chất liệu vàng 10K cao cấp và đá CZ lấp lánh. Thiết kế mạnh mẽ, sang trọng, phù hợp với phong cách hiện đại, tạo điểm nhấn độc đáo và cuốn hút cho phái mạnh. Phù hợp để làm quà tặng hoặc đeo trong các dịp đặc biệt', CAST(1.00 AS Decimal(18, 2)), 12750000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-004', N'Nhẫn đính đá CZ vàng 14K Aventador 1.5CT', N'Jewelry', N'Hướng đến sự tinh giản nhưng vẫn đảm bảo được sự sang trọng, đẳng cấp, nhẫn Aventador được những người thợ kim hoàn lành nghề chạm trổ từng đường kim loại góc cạnh, mạnh mẽ từ đai nhẫn đến bệ ổ nhẫn hình lục giác nhằm tôn lên viên chủ dáng tròn uy quyền. Nhẫn Aventador giúp phái mạnh khai mở một phong cách lịch lãm và cuốn hút.', CAST(1.00 AS Decimal(18, 2)), 30900000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-005', N'Nhẫn đính đá CZ vàng 14K Aventador 5C Y', N'Jewelry', N'Hướng đến sự tinh giản nhưng vẫn đảm bảo được sự sang trọng, đẳng cấp, nhẫn Aventador được những người thợ kim hoàn lành nghề chạm trổ từng đường kim loại góc cạnh, mạnh mẽ từ đai nhẫn đến bệ ổ nhẫn hình lục giác nhằm tôn lên viên chủ dáng tròn uy quyền. Nhẫn Aventador giúp phái mạnh khai mở một phong cách lịch lãm và cuốn hút.', CAST(1.00 AS Decimal(18, 2)), 27650000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-006', N'Nhẫn đính đá CZ vàng 10K Academic 5C', N'Jewelry', N'Thiết kế sang trọng: Nhẫn đính đá CZ vàng 10K Academic 5C mang đến vẻ đẹp sang trọng và tinh tế với kiểu dáng hiện đại, phù hợp cho cả nam và nữ.
Chất liệu cao cấp: Sản phẩm được chế tác từ vàng 10K chất lượng cao, bền đẹp và có độ bóng hoàn hảo, mang lại vẻ ngoài quý phái và đẳng cấp.
Đá CZ lấp lánh: Điểm nhấn của chiếc nhẫn là viên đá Cubic Zirconia (CZ) lấp lánh, mô phỏng hoàn hảo vẻ đẹp của kim cương, tạo nên sự cuốn hút ngay từ cái nhìn đầu tiên.', CAST(1.00 AS Decimal(18, 2)), 9500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-007', N'Nhẫn đính đá CZ vàng 10K Centralize', N'Jewelry', N'Thiết kế đẳng cấp: Nhẫn đính đá CZ vàng 10K Centralize sở hữu thiết kế hiện đại với phong cách trung tâm đá nổi bật, mang lại vẻ đẹp tinh tế và sang trọng.
Chất liệu vàng 10K: Được chế tác từ vàng 10K chất lượng cao, nhẫn không chỉ bền bỉ mà còn có độ bóng sáng hoàn hảo, thể hiện sự đẳng cấp và quý phái.
Đá CZ lấp lánh: Viên đá Cubic Zirconia (CZ) được đặt ở vị trí trung tâm, tỏa sáng rực rỡ và tạo điểm nhấn nổi bật cho chiếc nhẫn, thu hút ánh nhìn từ mọi góc độ.', CAST(1.00 AS Decimal(18, 2)), 3432000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-008', N'Nhẫn đính đá CZ vàng 10K Courtly', N'Jewelry', N'Kết hợp giữa kiểu dáng truyền thống và thiết kế đương đại, Courtly đẹp tinh tế, kiêu sa với các chi tiết thiết kế được lấy cảm hứng chế tác từ những cánh hoa mang đầy chất thơ và sự lãng mạn trên nền chất liệu vàng trắng thời thượng. Vẻ đẹp của Courtly được tăng lên khi đính những viên đá lấp lánh, làm nổi bật đôi tay mảnh khảnh. Courly giúp các Nàng trở thành một phiên bản đầy cá tính và tự tin.', CAST(1.00 AS Decimal(18, 2)), 6250000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-001', N'Vòng đeo tay đính đá CZ vàng 10K Belisa L2', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Belisa L2 được đính những viên đá Cubic Zirconia (CZ) lấp lánh, mang lại vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Belisa L2 phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 27900000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-002', N'Vòng đeo tay đính đá CZ vàng 10K Charvi', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Charvi được đính những viên đá Cubic Zirconia (CZ) lấp lánh, mang lại vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Charvi phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 27000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-003', N'Vòng đeo tay đính đá CZ vàng 10K Aretha', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Aretha được đính những viên đá Cubic Zirconia (CZ) lấp lánh, mang lại vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Aretha phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 30000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-004', N'Vòng đeo tay đính đá CZ vàng 10K Caste S3', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Caste S3 được đính những viên đá Cubic Zirconia (CZ) lấp lánh, mang lại vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Caste S3 phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 24500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-005', N'Vòng đeo tay đính đá CZ vàng 10K Chrysa NS', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Chrysa NS được đính những viên đá Cubic Zirconia (CZ) lấp lánh, tạo nên vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Chrysa NS phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 24000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-006', N'Vòng đeo tay đính đá CZ vàng 10K Courteous', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Courteous được đính những viên đá Cubic Zirconia (CZ) lấp lánh, tạo nên vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Courteous phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 20900000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-007', N'Vòng đeo tay đính đá CZ vàng 10K Cytheria', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Cytheria được đính những viên đá Cubic Zirconia (CZ) lấp lánh, tạo nên vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Cytheria phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 24100000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-008', N'Vòng đeo tay đính đá CZ vàng 10K Joanfia', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Joanfia được đính những viên đá Cubic Zirconia (CZ) lấp lánh, tạo nên vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Joanfia phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 21000000, 1)
GO
SET IDENTITY_INSERT [dbo].[SideDiamonds] ON 

INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (1, N'KC DIA WHIRD 1.2', 3000000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (2, N'KC DIA WHIRD 1.3', 3500000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (3, N'KC DIA WHIRD 1.5', 4000000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (4, N'Đá CZ 2.0', 2000000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (5, N'Không', 0)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (6, N'KC DIA WHIRD 1.6', 5000000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (7, N'KC DIA WHIRD 1.8', 6400000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (8, N'Đá CZ 2.5', 2500000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (9, N'Đá CZ 2.7', 2700000)
INSERT [dbo].[SideDiamonds] ([SideDiamondID], [SideDiamondName], [Price]) VALUES (10, N'Đá CZ 1.5', 2000000)
SET IDENTITY_INSERT [dbo].[SideDiamonds] OFF
GO
SET IDENTITY_INSERT [dbo].[Jewelry] ON 

INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (1, 5, N'N-001', 5, 9, 4, 6, 1, 16500000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (2, 5, N'N-002', 5, 9, 5, 0, 1, 17350000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (3, 5, N'N-003', 1, 1, 4, 10, 1, 12750000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (4, 6, N'DC-006', 6, 0, 5, 0, 2, 15300000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (5, 7, N'DC-007', 6, 0, 5, 0, 2, 39400000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (6, 1, N'MDC-001', 7, 1, 2, 10, 3, 8000000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (7, 6, N'MDC-002', 8, 1, 1, 8, 3, 9100000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (8, 1, N'MDC-006', 5, 1, 3, 4, 3, 11800000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (9, 1, N'MDC-007', 10, 1, 1, 8, 3, 28200000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (10, 5, N'VT-001', 8, 21, 5, 0, 4, 27900000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (11, 1, N'N-004', 1, 1, 5, 0, 1, 30900000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (12, 6, N'N-005', 1, 1, 5, 0, 1, 27650000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (13, 5, N'N-006', 1, 1, 4, 12, 1, 9500000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (14, 5, N'N-007', 5, 3, 5, 0, 1, 3432000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (15, 5, N'N-008', 5, 3, 4, 60, 1, 6250000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (16, 7, N'DC-001', 6, 0, 5, 0, 2, 15600000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (17, 7, N'DC-002', 6, 0, 5, 0, 2, 12200000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (18, 7, N'DC-003', 6, 0, 5, 0, 2, 11900000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (19, 2, N'DC-004', 6, 0, 5, 0, 2, 12700000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (20, 5, N'DC-005', 6, 0, 5, 0, 2, 2200000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (21, 7, N'DC-008', 6, 0, 5, 0, 2, 11500000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (22, 1, N'MDC-003', 11, 1, 1, 14, 3, 13400000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (23, 1, N'MDC-004', 10, 1, 3, 6, 3, 30000000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (24, 1, N'MDC-005', 10, 1, 1, 10, 3, 16900000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (25, 1, N'MDC-008', 10, 1, 1, 8, 3, 17000000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (26, 5, N'VT-002', 11, 1, 4, 7, 4, 27000000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (27, 5, N'VT-003', 11, 1, 4, 16, 4, 30000000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (28, 5, N'VT-004', 11, 1, 8, 70, 4, 24500000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (29, 5, N'VT-005', 5, 12, 5, 0, 4, 24000000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (30, 5, N'VT-006', 12, 1, 10, 90, 4, 20900000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (31, 5, N'VT-007', 10, 1, 4, 20, 4, 24100000);
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (32, 5, N'VT-008', 5, 8, 5, 0, 4, 21000000);
SET IDENTITY_INSERT [dbo].[Jewelry] OFF
GO
SET IDENTITY_INSERT [dbo].[Diamonds] ON 

INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (1, N'KC-3.6-001', CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), 14095000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (2, N'KC-4.1-001', CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), 24500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (3, N'KC-4.5-001', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), 35095000, 15);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (4, N'KC-5.4-001', CAST(2.00 AS Decimal(18, 2)), N'VS2', N'EX', N'D', CAST(5.40 AS Decimal(18, 2)), 44095000, 7);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (5, N'KC-3.6-002', CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), 13500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (6, N'KC-3.6-003', CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), 14500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (7, N'KC-3.6-004', CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'F', CAST(3.60 AS Decimal(18, 2)), 14000000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (8, N'KC-3.6-005', CAST(0.50 AS Decimal(18, 2)), N'VVS2', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), 15500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (9, N'KC-3.6-006', CAST(0.50 AS Decimal(18, 2)), N'VVS1', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), 16500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (10, N'KC-3.6-007', CAST(0.50 AS Decimal(18, 2)), N'VVS1', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), 16500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (11, N'KC-3.6-008', CAST(0.50 AS Decimal(18, 2)), N'IF', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), 18095000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (12, N'KC-4.1-002', CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), 24500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (13, N'KC-4.1-003', CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), 24500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (14, N'KC-4.1-004', CAST(0.75 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), 23500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (15, N'KC-4.1-005', CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), 25500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (16, N'KC-4.1-006', CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), 25000000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (17, N'KC-4.1-007', CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), 25000000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (18, N'KC-4.1-008', CAST(0.75 AS Decimal(18, 2)), N'VVS1', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), 26000000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (19, N'KC-4.5-002', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), 34095000, 20);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (20, N'KC-4.5-003', CAST(1.00 AS Decimal(18, 2)), N'IF', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), 37500000, 20);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (21, N'KC-4.5-004', CAST(1.00 AS Decimal(18, 2)), N'VVS1', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), 36500000, 20);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (22, N'KC-4.5-005', CAST(1.00 AS Decimal(18, 2)), N'VSS2', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), 36095000, 20);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (23, N'KC-4.5-006', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), 35095000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (24, N'KC-4.5-007', CAST(1.00 AS Decimal(18, 2)), N'IF', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), 37500000, 20);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (25, N'KC-4.5-008', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), 35095000, 15);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (26, N'KC-5.4-002', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'D', CAST(5.40 AS Decimal(18, 2)), 45095000, 13);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (27, N'KC-5.4-003', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), 43000000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (28, N'KC-5.4-004', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), 43500000, 5);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (29, N'KC-5.4-005', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), 43500000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (30, N'KC-5.4-006', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), 43000000, 10);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (31, N'KC-5.4-007', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), 43000000, 20);
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (32, N'KC-5.4-008', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'D', CAST(5.40 AS Decimal(18, 2)), 45095000, 14);
SET IDENTITY_INSERT [dbo].[Diamonds] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (2, N'Manager')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (3, N'Member')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (4, N'Delivery')
INSERT [dbo].[Roles] ([RoleId], [RoleName]) VALUES (5, N'Staff')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (1, 1, N'admin@example.com', N'Admin User', N'0912345678', N'admin', N'123', N'123 Admin St', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (2, 2, N'manager@example.com', N'Manager User', N'0987654321', N'manager', N'123', N'456 Manager Ave', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (3, 3, N'member@example.com', N'Member User', N'0915666777', N'member', N'123', N'789 Member Blvd', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (4, 4, N'delivery@example.com', N'Delivery User', N'0999888777', N'delivery', N'123', N'321 Delivery Dr', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (5, 5, N'staff@example.com', N'Staff User', N'0911122333', N'staff', N'123', N'654 Staff Ln', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (6, 3, N'kiettuantranle@gmail.com', N'', N'', N'kiettuantranle', N'123', N'', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (7, 3, N'hungcao@gmail.com', N'Nguyễn Trần Minh Hưng', N'', N'hungcao', N'123', N'44 Cao Lỗ p.5 q8', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (8, 3, N'khoanguyen@gmail.com', N'', N'', N'nguyendangkhoa', N'123', N'', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (9, 3, N'minhtuan22@gmail.com', N'Nguyễn Minh Tuấn', N'', N'minhtuanng', N'123', N'33 CMT8 P.4 Q.Tân Bình', 300, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (10, 3, N'hoaithanh283@gmail.com', N'', N'', N'hoaithanh', N'12345', N'', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (11, 3, N'minhhai123@gmail.com', N'Trần Minh Hải', N'', N'haine', N'@8321', N'22 Vĩnh Viễn p3 q10', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (12, 3, N'hieuleban@gmail.com', N'Lê Thanh Hiếu', N'', N'Thanh Lê', N'32138128312@', N'1231/03 Hòa hưng p3 q.10', 1000, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (13, 4, N'linhle002@gmail.com', N'Trần Thị Trúc Linh', N'', N'Trúc Linh', N'linhxinhdep123', N'10 Hàng Xanh p10 q. Bình Thạnh', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (14, 4, N'hanhtay@gmail.com', N'Lê Đình Nguyên', N'', N'Nguyên', N'nguyenhehuoc00', N'', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (15, 1, N'longnguyen@gmail.com', N'Nguyễn Hoàng Long', N'', N'Anh Long', N'longne', N'', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (16, 2, N'vinhht@gmail.com', N'Huỳnh Thanh Vinh', N'', N'Vinh Huỳnh', N'vinhht123', N'', 0, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (17, 3, N'tranglocxua@gmail.com', N'Ngô Thanh Trang', N'', N'trangjaeh', N'2301@trang', N'', 0, 0);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (18, 3, N'jenneni@gmail.com', N'Jenny Mias', N'', N'jenne1', N'0193je', N'', 2000, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (19, 1, N'kiet@gmailcom', N'Nguyễn Hào Kiệt', N'', N'kietuwy', N'2310kietne', N'', 10, 0);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (20, 4, N'hejau@gmailcom', N'Nguyễn Minh Tài', N'', N'tainguyen10', N'tainguyen123', N'', 0, 0);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (21, 2, N'phuonglinh219@gmail.com', N'Hà Phương Linh', N'', N'linhkkaka', N'12345678', N'', 0, 0);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (22, 3, N'vuongne@gmailcom', N'Trần Đức Vương', N'', N'vuongne', N'12345', N'', 200, 1);
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (23, 5, N'hung@gmail.com', N'Nguyễn Tuấn Hùng', N'', N'hung442', N'123456789', N'', 0, 1);
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Warranties] ON 

SET IDENTITY_INSERT [dbo].[Warranties] ON;
INSERT INTO [dbo].[Warranties] ([WarrantyId], [ProductId], [UserId], [StartDate], [EndDate]) 
VALUES (1, N'N-001', 1, CAST(N'2023-05-15' AS Date), CAST(N'2024-05-15' AS Date));

INSERT INTO [dbo].[Warranties] ([WarrantyId], [ProductId], [UserId], [StartDate], [EndDate]) 
VALUES (2, N'DC-001', 4, CAST(N'2023-05-18' AS Date), CAST(N'2024-05-18' AS Date));

INSERT INTO [dbo].[Warranties] ([WarrantyId], [ProductId], [UserId], [StartDate], [EndDate]) 
VALUES (3, N'DC-003', 4, CAST(N'2023-05-23' AS Date), CAST(N'2024-05-23' AS Date));

INSERT INTO [dbo].[Warranties] ([WarrantyId], [ProductId], [UserId], [StartDate], [EndDate]) 
VALUES (4, N'VT-001', 14, CAST(N'2023-05-23' AS Date), CAST(N'2024-05-23' AS Date));

INSERT INTO [dbo].[Warranties] ([WarrantyId], [ProductId], [UserId], [StartDate], [EndDate]) 
VALUES (5, N'N-001', 1, CAST(N'2023-05-20' AS Date), CAST(N'2024-05-20' AS Date));

INSERT INTO [dbo].[Warranties] ([WarrantyId], [ProductId], [UserId], [StartDate], [EndDate]) 
VALUES (6, N'N-001', 1, CAST(N'2023-05-15' AS Date), CAST(N'2024-05-15' AS Date));
SET IDENTITY_INSERT [dbo].[Warranties] OFF;
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (1, 1, CAST(200000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-15T00:00:00.0000000' AS DateTime2), N'Giao hàng lúc 1 giờ chiều', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (2, 1, CAST(22000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-19T00:00:00.0000000' AS DateTime2), N'Địa chỉ giao hàng mới, vui lòng liên hệ trước khi giao', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (3, 1, CAST(2300000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-20T00:00:00.0000000' AS DateTime2), N'Ưu đãi đặc biệt, giao hàng vào buổi sáng', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (4, 1, CAST(203100000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2023-05-24T00:00:00.0000000' AS DateTime2), N'Tặng kèm phiếu giảm giá, vui lòng để lại trước cửa', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (5, 2, CAST(370200000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2023-05-16T00:00:00.0000000' AS DateTime2), N'Yêu cầu gói quà, giao hàng trước 6 giờ tối', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (6, 2, CAST(380000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-21T00:00:00.0000000' AS DateTime2), N'Sản phẩm cao cấp, vui lòng giao vào buổi chiều', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (7, 3, CAST(1854000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-17T00:00:00.0000000' AS DateTime2), N'Liên hệ trước khi giao, gửi giúp tôi bên hàng xóm', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (8, 3, CAST(12000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-22T00:00:00.0000000' AS DateTime2), N'Yêu cầu giao vào buổi tối, vui lòng gọi trước', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (9, 3, CAST(3000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T00:00:00.0000000' AS DateTime2), N'Giao hàng vào buổi sáng', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (10, 3, CAST(103210000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-01-01T00:00:00.0000000' AS DateTime2), N'Giao hàng trước 12 giờ trưa', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (11, 4, CAST(2310000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-18T00:00:00.0000000' AS DateTime2), N'Khách hàng VIP, vui lòng giao hàng sớm nhất có thể', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (12, 4, CAST(7530000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-23T00:00:00.0000000' AS DateTime2), N'Giao hàng vào buổi sáng', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (13, 5, CAST(6000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T00:00:00.0000000' AS DateTime2), N'Giao hàng trước 6 giờ tối', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (14, 6, CAST(11421000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2024-07-17T00:00:00.0000000' AS DateTime2), N'Liên hệ trước khi giao hàng', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (15, 7, CAST(6000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T00:00:00.0000000' AS DateTime2), N'Giao hàng vào buổi chiều', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (16, 8, CAST(203000000.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2023-07-13T00:00:00.0000000' AS DateTime2), N'Giao hàng không thành công, vui lòng liên hệ lại', N'Shipper liên lạc không được');

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (17, 8, CAST(24000000.00 AS Decimal(18, 2)), N'Pending', CAST(N'2024-04-18T00:00:00.0000000' AS DateTime2), N'Chờ xác nhận địa chỉ giao hàng', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (18, 8, CAST(8000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2024-03-19T00:00:00.0000000' AS DateTime2), N'Giao hàng trước 9 giờ sáng', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (19, 9, CAST(180321900.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2023-01-18T00:00:00.0000000' AS DateTime2), N'Không muốn nhận hàng', N'Không chịu nhận hàng');

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (20, 10, CAST(111045000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2024-07-20T00:00:00.0000000' AS DateTime2), N'Giao hàng lúc 1 giờ chiều', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (21, 11, CAST(6000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T00:00:00.0000000' AS DateTime2), N'Giao hàng trước 6 giờ tối', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (22, 12, CAST(11421000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2024-07-17T00:00:00.0000000' AS DateTime2), N'Vui lòng giao trước giờ trưa', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (23, 13, CAST(2310000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-18T00:00:00.0000000' AS DateTime2), N'Khách hàng VIP, giao hàng vào buổi sáng', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (24, 14, CAST(7530000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-23T00:00:00.0000000' AS DateTime2), N'Giao hàng trước 9 giờ sáng', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (25, 15, CAST(6000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T00:00:00.0000000' AS DateTime2), N'Vui lòng gọi trước khi giao', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (26, 16, CAST(11421000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2024-07-17T00:00:00.0000000' AS DateTime2), N'Giao hàng lúc 1 giờ chiều', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (27, 17, CAST(6000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T00:00:00.0000000' AS DateTime2), N'Giao hàng vào buổi chiều', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (28, 18, CAST(203000000.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2023-07-13T00:00:00.0000000' AS DateTime2), N'Giao hàng không thành công, vui lòng liên hệ lại', N'Shipper liên lạc không được');

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (29, 19, CAST(180321900.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2023-01-18T00:00:00.0000000' AS DateTime2), N'Không muốn nhận hàng', N'Không chịu nhận hàng');

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (30, 20, CAST(111045000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2024-07-20T00:00:00.0000000' AS DateTime2), N'Giao hàng lúc 1 giờ chiều', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (31, 21, CAST(6000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T00:00:00.0000000' AS DateTime2), N'Vui lòng gọi trước khi giao', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (32, 22, CAST(11421000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2024-07-17T00:00:00.0000000' AS DateTime2), N'Giao hàng trước 12 giờ trưa', NULL);

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) 
VALUES (33, 23, CAST(2310000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-18T00:00:00.0000000' AS DateTime2), N'Khách hàng VIP, vui lòng giao vào buổi sáng', NULL);
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-001', 1, N'N-001', N'Nhẫn đính đá CZ vàng 10K Barony N W', 3000000, 2);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-002', 3, N'KC-3.6-003', N'Kim cương viên GIA 3.6ly G VS1 EX', 11421000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-003', 3, N'N-001', N'Nhẫn đính đá CZ vàng 10K Barony N W', 3000000, 10);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-004', 10, N'KC-3.6-001', N'Kim cương viên GIA 3.6ly D VS2 EX', 14095000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-005', 11, N'DC-001', N'Dây chuyền Vàng Trắng Ý 18K - Elegance Radiance', 25000000, 2);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-006', 11, N'KC-3.6-003', N'Kim cương viên GIA 3.6ly G VS1 EX', 11421000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-007', 12, N'DC-003', N'Dây chuyền Vàng Trắng Ý 18K - Eternal Sparkle', 24000000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-008', 12, N'KC-4.5-003', N'Kim cương viên GIA 4.5ly F VS2 EX', 13400000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-009', 18, N'KC-4.5-001', N'Kim cương viên GIA 4.5ly D VS2 EX', 34095000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-010', 23, N'KC-5.4-001', N'Kim cương viên GIA 5.4ly D VS2 EX', 44095000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-011', 24, N'KC-5.4-003', N'Kim cương viên GIA 5.4ly F VS2 EX', 43000000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-012', 24, N'VT-001', N'Vòng đeo tay đính đá CZ vàng 10K Belisa L2', 27900000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-014', 2, N'N-002', N'Nhẫn đính đá CZ vàng 10K Authentic', 17350000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-015', 7, N'N-003', N'Nhẫn nam đính đá CZ vàng 10K Creator 5C', 12750000, 2);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-016', 8, N'N-004', N'Nhẫn đính đá CZ vàng 14K Aventador 1.5CT', 30900000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-017', 9, N'VT-001', N'Vòng đeo tay đính đá CZ vàng 10K Belisa L2', 27900000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-018', 13, N'VT-002', N'Vòng đeo tay đính đá CZ vàng 10K Charvi', 27000000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-019', 15, N'VT-003', N'Vòng đeo tay đính đá CZ vàng 10K Aretha', 30000000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-020', 21, N'VT-004', N'Vòng đeo tay đính đá CZ vàng 10K Caste S3', 24500000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-021', 27, N'VT-005', N'Vòng đeo tay đính đá CZ vàng 10K Chrysa NS', 24000000, 1);

INSERT INTO [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) 
VALUES (N'OD-022', 31, N'N-005', N'Nhẫn đính đá CZ vàng 14K Aventador 5C Y', 27650000, 1);
GO
SET IDENTITY_INSERT [dbo].[JewelrySizes] ON 

INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (1, 1, 10, 50);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (2, 2, 11, 35);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (3, 3, 12, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (4, 1, 11, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (5, 1, 12, 10);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (6, 1, 13, 4);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (7, 1, 15, 5);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (8, 1, 20, 8);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (9, 1, 17, 5);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (10, 2, 17, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (11, 2, 15, 17);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (12, 2, 18, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (13, 2, 13, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (14, 2, 14, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (15, 3, 10, 13);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (16, 3, 12, 40);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (17, 3, 17, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (18, 3, 18, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (19, 3, 16, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (20, 3, 14, 22);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (21, 11, 10, 23);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (22, 11, 13, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (23, 11, 11, 10);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (24, 11, 12, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (25, 11, 17, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (26, 11, 15, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (27, 12, 10, 11);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (28, 12, 11, 13);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (29, 12, 14, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (30, 12, 15, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (31, 12, 16, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (32, 12, 17, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (33, 12, 18, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (34, 13, 10, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (35, 13, 11, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (36, 13, 12, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (37, 13, 13, 11);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (38, 13, 14, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (39, 13, 20, 3);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (40, 14, 10, 4);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (41, 14, 11, 40);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (42, 14, 12, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (43, 14, 13, 33);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (44, 14, 15, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (45, 14, 16, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (46, 14, 20, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (47, 15, 11, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (48, 15, 12, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (49, 15, 13, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (50, 15, 14, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (51, 15, 16, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (52, 15, 18, 22);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (53, 15, 20, 13);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (54, 5, 0, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (55, 6, 0, 15);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (56, 7, 0, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (57, 8, 0, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (58, 9, 0, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (59, 10, 0, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (60, 16, 0, 29);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (61, 17, 0, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (62, 18, 0, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (63, 19, 0, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (64, 20, 0, 40);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (65, 21, 0, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (66, 22, 0, 23);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (67, 23, 0, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (68, 24, 0, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (69, 25, 0, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (70, 26, 0, 30);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (71, 27, 0, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (72, 28, 0, 20);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (73, 29, 0, 23);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (74, 30, 0, 38);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (75, 31, 0, 80);
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (76, 32, 0, 40);


SET IDENTITY_INSERT [dbo].[JewelrySizes] OFF
GO
SET IDENTITY_INSERT [dbo].[DiamondPrices] ON 

INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (1, CAST(0.50 AS Decimal(18, 2)), N'IF', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), CAST(18095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (2, CAST(0.50 AS Decimal(18, 2)), N'VVS1', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), CAST(17095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (3, CAST(0.50 AS Decimal(18, 2)), N'VVS2', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), CAST(16095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (4, CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), CAST(15095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (5, CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), CAST(14095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (6, CAST(0.50 AS Decimal(18, 2)), N'IF', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), CAST(17500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (7, CAST(0.50 AS Decimal(18, 2)), N'VVS1', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), CAST(16500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (8, CAST(0.50 AS Decimal(18, 2)), N'VVS2', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), CAST(15500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (9, CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), CAST(14500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (10, CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), CAST(13500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (11, CAST(0.50 AS Decimal(18, 2)), N'IF', N'EX', N'F', CAST(3.60 AS Decimal(18, 2)), CAST(17000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (12, CAST(0.50 AS Decimal(18, 2)), N'VVS1', N'EX', N'F', CAST(3.60 AS Decimal(18, 2)), CAST(16000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (13, CAST(0.50 AS Decimal(18, 2)), N'VVS2', N'EX', N'F', CAST(3.60 AS Decimal(18, 2)), CAST(15000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (14, CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'F', CAST(3.60 AS Decimal(18, 2)), CAST(14000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (15, CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(3.60 AS Decimal(18, 2)), CAST(13000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (16, CAST(0.75 AS Decimal(18, 2)), N'IF', N'EX', N'D', CAST(4.10 AS Decimal(18, 2)), CAST(28095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (17, CAST(0.75 AS Decimal(18, 2)), N'VVS1', N'EX', N'D', CAST(4.10 AS Decimal(18, 2)), CAST(27095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (18, CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'D', CAST(4.10 AS Decimal(18, 2)), CAST(26095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (19, CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'D', CAST(4.10 AS Decimal(18, 2)), CAST(25095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (20, CAST(0.75 AS Decimal(18, 2)), N'VS2', N'EX', N'D', CAST(4.10 AS Decimal(18, 2)), CAST(24095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (21, CAST(0.75 AS Decimal(18, 2)), N'IF', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), CAST(27500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (22, CAST(0.75 AS Decimal(18, 2)), N'VVS1', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), CAST(26500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (23, CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), CAST(25500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (24, CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), CAST(24500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (25, CAST(0.75 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), CAST(23500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (26, CAST(0.75 AS Decimal(18, 2)), N'IF', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), CAST(27000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (27, CAST(0.75 AS Decimal(18, 2)), N'VVS1', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), CAST(26000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (28, CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), CAST(25000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (29, CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), CAST(24000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (30, CAST(0.75 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), CAST(23000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (31, CAST(1.00 AS Decimal(18, 2)), N'IF', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), CAST(38095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (32, CAST(1.00 AS Decimal(18, 2)), N'VVS1', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), CAST(37095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (33, CAST(1.00 AS Decimal(18, 2)), N'VVS2', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), CAST(36095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (34, CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), CAST(35095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (35, CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'D', CAST(4.50 AS Decimal(18, 2)), CAST(34095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (36, CAST(1.00 AS Decimal(18, 2)), N'IF', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), CAST(37500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (37, CAST(1.00 AS Decimal(18, 2)), N'VVS1', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), CAST(36500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (38, CAST(1.00 AS Decimal(18, 2)), N'VVS2', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), CAST(35500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (39, CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), CAST(34500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (40, CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(4.50 AS Decimal(18, 2)), CAST(33500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (41, CAST(1.00 AS Decimal(18, 2)), N'IF', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), CAST(37000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (42, CAST(1.00 AS Decimal(18, 2)), N'VVS1', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), CAST(36000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (43, CAST(1.00 AS Decimal(18, 2)), N'VVS2', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), CAST(35000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (44, CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), CAST(34000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (45, CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), CAST(33000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (46, CAST(2.00 AS Decimal(18, 2)), N'IF', N'EX', N'D', CAST(5.40 AS Decimal(18, 2)), CAST(48095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (47, CAST(2.00 AS Decimal(18, 2)), N'VVS1', N'EX', N'D', CAST(5.40 AS Decimal(18, 2)), CAST(47095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (48, CAST(2.00 AS Decimal(18, 2)), N'VVS2', N'EX', N'D', CAST(5.40 AS Decimal(18, 2)), CAST(46095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (49, CAST(2.00 AS Decimal(18, 2)), N'VS1', N'EX', N'D', CAST(5.40 AS Decimal(18, 2)), CAST(45095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (50, CAST(2.00 AS Decimal(18, 2)), N'VS2', N'EX', N'D', CAST(5.40 AS Decimal(18, 2)), CAST(44095000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (51, CAST(2.00 AS Decimal(18, 2)), N'IF', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), CAST(47500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (52, CAST(2.00 AS Decimal(18, 2)), N'VVS1', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), CAST(46500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (53, CAST(2.00 AS Decimal(18, 2)), N'VVS2', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), CAST(45500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (54, CAST(2.00 AS Decimal(18, 2)), N'VS1', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), CAST(44500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (55, CAST(2.00 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), CAST(43500000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (56, CAST(2.00 AS Decimal(18, 2)), N'IF', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), CAST(47000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (57, CAST(2.00 AS Decimal(18, 2)), N'VVS1', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), CAST(46000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (58, CAST(2.00 AS Decimal(18, 2)), N'VVS2', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), CAST(45000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (59, CAST(2.00 AS Decimal(18, 2)), N'VS1', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), CAST(44000000.00 AS Decimal(18, 2)))
INSERT [dbo].[DiamondPrices] ([Id], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [Price]) VALUES (60, CAST(2.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), CAST(43000000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[DiamondPrices] OFF
GO
