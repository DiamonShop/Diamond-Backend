USE [DiamondStore]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Nhẫn')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Dây chuyền')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Mặt dây chuyền')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Vòng tay')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (5, N'Kim cương')
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
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, có độ bóng sáng và bền bỉ, mang lại vẻ ngoài đẳng cấp và quý phái.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-002', N'Dây chuyền Vàng Trắng Ý 18K - Classic Grace', N'Jewelry', N'Thiết kế thanh lịch: Dây chuyền Classic Grace mang phong cách cổ điển với thiết kế tinh xảo, tôn lên vẻ đẹp trang nhã và thanh lịch của người đeo.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, có độ sáng bóng và bền bỉ, mang lại vẻ ngoài sang trọng và đẳng cấp.
Phong cách cổ điển: Dây chuyền Classic Grace phù hợp cho những ai yêu thích phong cách cổ điển, trang nhã, dễ dàng kết hợp với nhiều trang phục và phong cách khác nhau.
Chi tiết tinh xảo: Các chi tiết của dây chuyền được gia công tỉ mỉ, mang đến sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-003', N'Dây chuyền Vàng Trắng Ý 18K - Pure Elegance', N'Jewelry', N'Thiết kế tinh tế: Dây chuyền Pure Elegance mang đến vẻ đẹp tinh tế và sang trọng với kiểu dáng hiện đại, phù hợp với mọi phong cách thời trang.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, với độ bóng sáng hoàn hảo, đảm bảo sự bền bỉ và đẳng cấp cho người đeo.
Phong cách thời trang: Dây chuyền Pure Elegance phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện đặc biệt, giúp bạn luôn tự tin và nổi bật.
Độ dài hoàn hảo: Độ dài dây chuyền được thiết kế vừa vặn, dễ dàng kết hợp với nhiều loại trang phục và phong cách khác nhau.
Gia công tinh xảo: Mỗi chi tiết của dây chuyền được gia công tỉ mỉ, mang đến sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 7400000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-004', N'Dây chuyền Vàng Ý 18K - Eternal Shine', N'Jewelry', N'Thiết kế đẳng cấp: Dây chuyền Eternal Shine mang vẻ đẹp đẳng cấp và sang trọng với thiết kế tinh xảo, tôn lên sự quý phái và phong cách của người đeo.
Vàng Ý 18K: Chất liệu vàng Ý 18K cao cấp, nổi tiếng với độ bóng sáng và độ bền vượt trội, đảm bảo vẻ đẹp lâu dài và giá trị của sản phẩm.
Món quà ý nghĩa: Dây chuyền Eternal Shine là món quà hoàn hảo dành cho người thân, bạn bè hoặc đối tác, thể hiện sự trân trọng và tình cảm chân thành.
Dễ dàng bảo quản: Với chất liệu vàng Ý 18K, dây chuyền không chỉ bền bỉ theo thời gian mà còn dễ dàng bảo quản và làm sạch, luôn giữ được vẻ đẹp ban đầu.', CAST(1.00 AS Decimal(18, 2)), 6500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-005', N'Dây chuyền Vàng Trắng 10K - Radiant Charm', N'Jewelry', N'Thiết kế hiện đại: Dây chuyền Radiant Charm mang vẻ đẹp hiện đại và tinh tế, thiết kế đơn giản nhưng không kém phần sang trọng, phù hợp với nhiều phong cách thời trang.
Vàng Trắng 10K: Chất liệu vàng trắng 10K cao cấp, có độ bóng sáng hoàn hảo và bền bỉ, mang lại vẻ ngoài quý phái và đẳng cấp.
Phong cách thời trang: Dây chuyền Radiant Charm phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện đặc biệt, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của dây chuyền được gia công tỉ mỉ, mang đến sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 6000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-006', N'Dây chuyền Vàng 14K - Golden Elegance', N'Jewelry', N'Thiết kế sang trọng: Dây chuyền Golden Elegance sở hữu thiết kế thanh lịch và tinh tế, phù hợp với nhiều phong cách thời trang và dễ dàng kết hợp với các loại trang sức khác.
Vàng 14K: Chất liệu vàng 14K cao cấp, có độ sáng bóng tự nhiên và bền bỉ, mang lại vẻ ngoài đẳng cấp và quý phái.
Phong cách thời trang: Dây chuyền Golden Elegance phù hợp cho nhiều dịp, từ công sở, dạo phố đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.', CAST(1.00 AS Decimal(18, 2)), 6500000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-007', N'Dây chuyền Vàng Trắng Ý 18K - Eternal Sparkle', N'Jewelry', N'Thiết kế sang trọng: Dây chuyền Eternal Sparkle sở hữu thiết kế thanh lịch và tinh tế, tôn lên vẻ đẹp hiện đại và đẳng cấp của người đeo.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, có độ sáng bóng hoàn hảo và bền bỉ, mang lại vẻ ngoài quý phái và tinh tế.
Gia công tinh xảo: Mỗi chi tiết của dây chuyền được gia công tỉ mỉ bởi những nghệ nhân lành nghề, mang đến sản phẩm hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'DC-008', N'Dây chuyền Vàng Trắng Ý 18K - Radiant Elegance', N'Jewelry', N'Thiết kế thanh lịch: Dây chuyền Radiant Elegance được thiết kế với phong cách tinh tế và hiện đại, mang lại vẻ đẹp thanh lịch và quý phái cho người đeo.
Vàng Trắng Ý 18K: Chất liệu vàng trắng Ý 18K cao cấp, nổi bật với độ sáng bóng tự nhiên và độ bền cao, đảm bảo vẻ đẹp lâu dài và giá trị của sản phẩm.
Phong cách thời trang: Dây chuyền Radiant Elegance phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.', CAST(1.00 AS Decimal(18, 2)), 8000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-001', N'Kim cương viên GIA 3.6ly E VS2 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 25000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-002', N'Kim cương viên GIA 3.6ly G VS2 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 11045000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-003', N'Kim cương viên GIA 3.6ly G VS1 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 11421000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-004', N'Kim cương viên GIA 3.6ly F VS1 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 12267000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-005', N'Kim cương viên GIA 3.6ly H VVS2 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 12361000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-006', N'Kim cương viên GIA 3.6ly G VVS1 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 13160000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-007', N'Kim cương viên GIA 3.6ly G VVS1 EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 13160000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-3.6-008', N'Kim cương viên GIA 3.6ly D IF EX', N'Diamond', N'Kim cương là biểu tượng của sự vĩnh cửu và giá trị, là món đầu tư thông minh và bền vững, không chỉ là trang sức mà còn là tài sản quý giá.
Chứng nhận GIA: Kim cương viên 3.6 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 3.6 ly: Với kích thước 3.6 ly, viên kim cương này mang lại vẻ đẹp tinh tế, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 3.6 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 18095000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-001', N'Kim cương viên GIA 4.1ly G VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 12000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-002', N'Kim cương viên GIA 4.1ly G VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-003', N'Kim cương viên GIA 4.1ly G VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-004', N'Kim cương viên GIA 4.1ly E VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-005', N'Kim cương viên GIA 4.1ly G VVS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-006', N'Kim cương viên GIA 4.1ly F VVS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-007', N'Kim cương viên GIA 4.1ly F VVS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.1-008', N'Kim cương viên GIA 4.1ly F VVS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.1 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.1 ly: Với kích thước 4.1 ly, viên kim cương này mang lại vẻ đẹp tinh tế và rực rỡ, hoàn hảo cho các thiết kế trang sức như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.1 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng rực rỡ và lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-001', N'Kim cương viên GIA 4.5ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 2000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-002', N'Kim cương viên GIA 4.5ly G VS2 EX ', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 5000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-003', N'Kim cương viên GIA 4.5ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 5000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-004', N'Kim cương viên GIA 4.5ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 5000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-005', N'Kim cương viên GIA 4.5ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 5000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-006', N'Kim cương viên GIA 4.5ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 5000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-007', N'Kim cương viên GIA 4.5ly G VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 5000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-4.5-008', N'Kim cương viên GIA 4.5ly G VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 4.5 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 4.5 ly: Với kích thước 4.5 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và tinh tế, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 4.5 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 5000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-001', N'Kim cương viên GIA 5.4ly H VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-002', N'Kim cương viên GIA 5.4ly H VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-003', N'Kim cương viên GIA 5.4ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-004', N'Kim cương viên GIA 5.4ly E VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-005', N'Kim cương viên GIA 5.4ly E VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-006', N'Kim cương viên GIA 5.4ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-007', N'Kim cương viên GIA 5.4ly F VS2 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'KC-5.4-008', N'Kim cương viên GIA 5.4ly H VS1 EX', N'Diamond', N'Chứng nhận GIA: Viên kim cương 5.4 ly được chứng nhận bởi Viện Ngọc học Hoa Kỳ (GIA), đảm bảo chất lượng, độ tinh khiết và nguồn gốc xuất xứ rõ ràng.
Kích thước 5.4 ly: Với kích thước 5.4 ly, viên kim cương này mang lại vẻ đẹp rực rỡ và ấn tượng, hoàn hảo cho các thiết kế trang sức cao cấp như nhẫn, dây chuyền, hoa tai và vòng tay.
Độ tinh khiết cao: Kim cương GIA 5.4 ly có độ tinh khiết cao, ít tạp chất và khuyết điểm, giúp viên kim cương tỏa sáng lấp lánh dưới mọi góc độ ánh sáng.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-001', N'Mặt kim cương tấm vàng 14K Amuse N 2C', N'Jewelry', N'Kim cương tấm rực rỡ: Mặt kim cương được gắn những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh và rực rỡ, thu hút mọi ánh nhìn.
Phong cách thời trang: Mặt kim cương Amuse N 2C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, mang đến sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-002', N'Mặt kim cương tấm vàng 14K Accius B 2C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương được gắn những viên kim cương tấm nhỏ, mang lại vẻ lấp lánh rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Accius B 2C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 2000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-003', N'Mặt kim cương tấm vàng 14K Adiva 1CT', N'Jewelry', N'Kim cương 1 carat: Mặt kim cương Adiva nổi bật với viên kim cương chính có trọng lượng 1 carat, mang lại vẻ lấp lánh rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Adiva 1CT phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-004', N'Mặt kim cương tấm vàng 14K Arlana N 5C', N'Jewelry', N'Kim cương tấm rực rỡ: Mặt kim cương được gắn với những viên kim cương tấm nhỏ, tạo nên sự lấp lánh và rực rỡ, thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Arlana N 5C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.
', CAST(1.00 AS Decimal(18, 2)), 4300000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-005', N'Mặt kim cương tấm vàng 14K Fetchingly N 3C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương được gắn những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh rực rỡ, thu hút mọi ánh nhìn.
Phong cách thời trang: Mặt kim cương Fetchingly N 3C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 3400000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-006', N'Mặt kim cương tấm vàng 14K Flaring 2C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương được gắn với những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh rực rỡ, thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Flaring 2C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 3100000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-007', N'Mặt kim cương tấm vàng 14K Firming 3C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương được gắn với những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh rực rỡ, thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Firming 3C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 4200000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'MDC-008', N'Mặt kim cương tấm vàng 14K Florid 3C', N'Jewelry', N'Kim cương tấm lấp lánh: Mặt kim cương Florid 3C được gắn những viên kim cương tấm nhỏ, tạo nên vẻ lấp lánh rực rỡ, thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Mặt kim cương Florid 3C phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của mặt kim cương được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 6000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-001', N'Nhẫn đính đá CZ vàng 10K Barony N W', N'Jewelry', N'Sở hữu dáng nhẫn mạnh mẽ, cứng cáp, nhẫn Barony gây ấn tượng với Phái mạnh với thiết kế 9 viên đá ở trung tâm mặt nhẫn và những viên tấm hai bên đai nhẫn được sắp xếp tỉ mỉ thằng tắp với một tỉ lệ hoàn hảo. Barony là một lựa chọn lý tưởng giúp Phái mạnh khẳng định phong cách trong mọi hoàn cảnh.', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-002', N'Nhẫn đính đá CZ vàng 10K Authentic', N'Jewelry', N'Authentic với thiết kế đặc biệt kết hợp giữa hai loại vàng trắng và vàng vàng, tạo nên phong cách mạnh mẽ, nam tính và sang trọng. Được chế tác tinh xảo đến từng chi tiết và linh động theo nhu cầu', CAST(1.00 AS Decimal(18, 2)), 5000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-003', N'Nhẫn nam đính đá CZ vàng 10K Creator 5C', N'Jewelry', N'Một sản phẩm tinh xảo, kết hợp giữa chất liệu vàng 10K cao cấp và đá CZ lấp lánh. Thiết kế mạnh mẽ, sang trọng, phù hợp với phong cách hiện đại, tạo điểm nhấn độc đáo và cuốn hút cho phái mạnh. Phù hợp để làm quà tặng hoặc đeo trong các dịp đặc biệt', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-004', N'Nhẫn đính đá CZ vàng 14K Aventador 1.5CT', N'Jewelry', N'Hướng đến sự tinh giản nhưng vẫn đảm bảo được sự sang trọng, đẳng cấp, nhẫn Aventador được những người thợ kim hoàn lành nghề chạm trổ từng đường kim loại góc cạnh, mạnh mẽ từ đai nhẫn đến bệ ổ nhẫn hình lục giác nhằm tôn lên viên chủ dáng tròn uy quyền. Nhẫn Aventador giúp phái mạnh khai mở một phong cách lịch lãm và cuốn hút.', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-005', N'Nhẫn đính đá CZ vàng 14K Aventador 5C Y', N'Jewelry', N'Hướng đến sự tinh giản nhưng vẫn đảm bảo được sự sang trọng, đẳng cấp, nhẫn Aventador được những người thợ kim hoàn lành nghề chạm trổ từng đường kim loại góc cạnh, mạnh mẽ từ đai nhẫn đến bệ ổ nhẫn hình lục giác nhằm tôn lên viên chủ dáng tròn uy quyền. Nhẫn Aventador giúp phái mạnh khai mở một phong cách lịch lãm và cuốn hút.', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-006', N'Nhẫn đính đá CZ vàng 10K Academic 5C', N'Jewelry', N'Thiết kế sang trọng: Nhẫn đính đá CZ vàng 10K Academic 5C mang đến vẻ đẹp sang trọng và tinh tế với kiểu dáng hiện đại, phù hợp cho cả nam và nữ.
Chất liệu cao cấp: Sản phẩm được chế tác từ vàng 10K chất lượng cao, bền đẹp và có độ bóng hoàn hảo, mang lại vẻ ngoài quý phái và đẳng cấp.
Đá CZ lấp lánh: Điểm nhấn của chiếc nhẫn là viên đá Cubic Zirconia (CZ) lấp lánh, mô phỏng hoàn hảo vẻ đẹp của kim cương, tạo nên sự cuốn hút ngay từ cái nhìn đầu tiên.', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-007', N'Nhẫn đính đá CZ vàng 10K Centralize', N'Jewelry', N'Thiết kế đẳng cấp: Nhẫn đính đá CZ vàng 10K Centralize sở hữu thiết kế hiện đại với phong cách trung tâm đá nổi bật, mang lại vẻ đẹp tinh tế và sang trọng.
Chất liệu vàng 10K: Được chế tác từ vàng 10K chất lượng cao, nhẫn không chỉ bền bỉ mà còn có độ bóng sáng hoàn hảo, thể hiện sự đẳng cấp và quý phái.
Đá CZ lấp lánh: Viên đá Cubic Zirconia (CZ) được đặt ở vị trí trung tâm, tỏa sáng rực rỡ và tạo điểm nhấn nổi bật cho chiếc nhẫn, thu hút ánh nhìn từ mọi góc độ.', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'N-008', N'Nhẫn đính đá CZ vàng 10K Courtly', N'Jewelry', N'Kết hợp giữa kiểu dáng truyền thống và thiết kế đương đại, Courtly đẹp tinh tế, kiêu sa với các chi tiết thiết kế được lấy cảm hứng chế tác từ những cánh hoa mang đầy chất thơ và sự lãng mạn trên nền chất liệu vàng trắng thời thượng. Vẻ đẹp của Courtly được tăng lên khi đính những viên đá lấp lánh, làm nổi bật đôi tay mảnh khảnh. Courly giúp các Nàng trở thành một phiên bản đầy cá tính và tự tin.', CAST(1.00 AS Decimal(18, 2)), 3000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-001', N'Vòng đeo tay đính đá CZ vàng 10K Belisa L2', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Belisa L2 được đính những viên đá Cubic Zirconia (CZ) lấp lánh, mang lại vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Belisa L2 phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-002', N'Vòng đeo tay đính đá CZ vàng 10K Charvi', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Charvi được đính những viên đá Cubic Zirconia (CZ) lấp lánh, mang lại vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Charvi phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 7000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-003', N'Vòng đeo tay đính đá CZ vàng 10K Aretha', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Aretha được đính những viên đá Cubic Zirconia (CZ) lấp lánh, mang lại vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Aretha phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 7400000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-004', N'Vòng đeo tay đính đá CZ vàng 10K Caste S3', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Caste S3 được đính những viên đá Cubic Zirconia (CZ) lấp lánh, mang lại vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Caste S3 phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-005', N'Vòng đeo tay đính đá CZ vàng 10K Chrysa NS', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Chrysa NS được đính những viên đá Cubic Zirconia (CZ) lấp lánh, tạo nên vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Chrysa NS phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 4100000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-006', N'Vòng đeo tay đính đá CZ vàng 10K Courteous', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Courteous được đính những viên đá Cubic Zirconia (CZ) lấp lánh, tạo nên vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Courteous phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 2000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-007', N'Vòng đeo tay đính đá CZ vàng 10K Cytheria', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Cytheria được đính những viên đá Cubic Zirconia (CZ) lấp lánh, tạo nên vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Cytheria phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
INSERT [dbo].[Products] ([ProductId], [ProductName], [ProductType], [Description], [MarkupRate], [MarkupPrice], [IsActive]) VALUES (N'VT-008', N'Vòng đeo tay đính đá CZ vàng 10K Joanfia', N'Jewelry', N'Đính đá CZ lấp lánh: Vòng đeo tay Joanfia được đính những viên đá Cubic Zirconia (CZ) lấp lánh, tạo nên vẻ rực rỡ và thu hút ánh nhìn từ mọi góc độ.
Phong cách thời trang: Vòng đeo tay Joanfia phù hợp cho nhiều dịp, từ công việc hàng ngày đến các sự kiện quan trọng, giúp bạn luôn tự tin và nổi bật.
Gia công tinh xảo: Các chi tiết của vòng đeo tay được gia công tỉ mỉ bởi những nghệ nhân lành nghề, đảm bảo sự hoàn thiện tuyệt đối và sự tinh tế trong từng đường nét.', CAST(1.00 AS Decimal(18, 2)), 4000000, 1)
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

INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (1, 5, N'N-001', 5, 9, 4, 6, 1, 16500000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (2, 5, N'N-002', 5, 9, 5, 0, 1, 17350000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (3, 5, N'N-003', 1, 1, 4, 10, 1, 12750000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (10, 6, N'DC-006', 6, 0, 5, 0, 2, 15300000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (11, 7, N'DC-007', 6, 0, 5, 0, 2, 39400000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (13, 1, N'MDC-001', 7, 1, 2, 10, 3, 8000000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (14, 6, N'MDC-002', 8, 1, 1, 8, 3, 9100000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (18, 1, N'MDC-006', 5, 1, 3, 4, 3, 11800000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (19, 1, N'MDC-007', 10, 1, 1, 8, 3, 28200000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (21, 5, N'VT-001', 8, 21, 5, 0, 4, 27900000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (22, 1, N'N-004', 1, 1, 5, 0, 1, 30900000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (24, 6, N'N-005', 1, 1, 5, 0, 1, 27650000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (25, 5, N'N-006', 1, 1, 4, 12, 1, 9500000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (26, 5, N'N-007', 5, 3, 5, 0, 1, 3432000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (27, 5, N'N-008', 5, 3, 4, 60, 1, 6250000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (28, 7, N'DC-001', 6, 0, 5, 0, 2, 15600000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (29, 7, N'DC-002', 6, 0, 5, 0, 2, 12200000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (30, 7, N'DC-003', 6, 0, 5, 0, 2, 11900000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (31, 2, N'DC-004', 6, 0, 5, 0, 2, 12700000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (32, 5, N'DC-005', 6, 0, 5, 0, 2, 2200000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (33, 7, N'DC-008', 6, 0, 5, 0, 2, 11500000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (34, 1, N'MDC-003', 11, 1, 1, 14, 3, 13400000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (35, 1, N'MDC-004', 10, 1, 3, 6, 3, 30000000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (36, 1, N'MDC-005', 10, 1, 1, 10, 3, 16900000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (37, 1, N'MDC-008', 10, 1, 1, 8, 3, 17000000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (38, 5, N'VT-002', 11, 1, 4, 7, 4, 27000000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (39, 5, N'VT-003', 11, 1, 4, 16, 4, 30000000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (40, 5, N'VT-004', 11, 1, 8, 70, 4, 24500000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (41, 5, N'VT-005', 5, 12, 5, 0, 4, 24000000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (42, 5, N'VT-006', 12, 1, 10, 90, 4, 20900000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (43, 5, N'VT-007', 10, 1, 4, 20, 4, 24100000)
INSERT [dbo].[Jewelry] ([JewelryID], [JewelrySettingID], [ProductID], [MainDiamondID], [MainDiamondQuantity], [SideDiamondID], [SideDiamondQuantity], [CategoryId], [BasePrice]) VALUES (44, 5, N'VT-008', 5, 8, 5, 0, 4, 21000000)
SET IDENTITY_INSERT [dbo].[Jewelry] OFF
GO
SET IDENTITY_INSERT [dbo].[Diamonds] ON 

INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (1, N'KC-3.6-001', CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(3.60 AS Decimal(18, 2)), 12267000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (2, N'KC-4.1-001', CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'G', CAST(4.10 AS Decimal(18, 2)), 16967000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (3, N'KC-4.5-001', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'G', CAST(4.50 AS Decimal(18, 2)), 16967000, 15)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (4, N'KC-5.4-001', CAST(2.00 AS Decimal(18, 2)), N'VS2', N'EX', N'H', CAST(5.40 AS Decimal(18, 2)), 66129000, 7)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (6, N'KC-3.6-002', CAST(0.50 AS Decimal(18, 2)), N'VS2', N'EX', N'G', CAST(3.60 AS Decimal(18, 2)), 11045000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (8, N'KC-3.6-003', CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'G', CAST(3.60 AS Decimal(18, 2)), 11421000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (9, N'KC-3.6-004', CAST(0.50 AS Decimal(18, 2)), N'VS1', N'EX', N'F', CAST(3.60 AS Decimal(18, 2)), 12267000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (10, N'KC-3.6-005', CAST(0.50 AS Decimal(18, 2)), N'VVS2', N'EX', N'H', CAST(3.60 AS Decimal(18, 2)), 12361000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (11, N'KC-3.6-006', CAST(0.50 AS Decimal(18, 2)), N'VVS1', N'EX', N'G', CAST(3.60 AS Decimal(18, 2)), 13160000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (12, N'KC-3.6-007', CAST(0.50 AS Decimal(18, 2)), N'VVS1', N'EX', N'G', CAST(3.60 AS Decimal(18, 2)), 13160000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (13, N'KC-3.6-008', CAST(0.50 AS Decimal(18, 2)), N'IF', N'EX', N'D', CAST(3.60 AS Decimal(18, 2)), 18095000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (17, N'KC-4.1-002', CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'G', CAST(4.10 AS Decimal(18, 2)), 16967000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (18, N'KC-4.1-003', CAST(0.75 AS Decimal(18, 2)), N'VS1', N'EX', N'G', CAST(4.10 AS Decimal(18, 2)), 16967000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (19, N'KC-4.1-004', CAST(0.75 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(4.10 AS Decimal(18, 2)), 18659000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (20, N'KC-4.1-005', CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'G', CAST(4.10 AS Decimal(18, 2)), 18894000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (21, N'KC-4.1-006', CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), 21432000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (22, N'KC-4.1-007', CAST(0.75 AS Decimal(18, 2)), N'VVS2', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), 21432000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (23, N'KC-4.1-008', CAST(0.75 AS Decimal(18, 2)), N'VVS1', N'EX', N'F', CAST(4.10 AS Decimal(18, 2)), 22325000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (27, N'KC-4.5-002', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'G', CAST(4.50 AS Decimal(18, 2)), 21056000, 20)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (28, N'KC-4.5-003', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), 21582000, 20)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (31, N'KC-4.5-004', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), 21582000, 20)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (32, N'KC-4.5-005', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), 21582000, 20)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (33, N'KC-4.5-006', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), 21582000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (36, N'KC-4.5-007', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(4.50 AS Decimal(18, 2)), 21056000, 20)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (38, N'KC-4.5-008', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'G', CAST(4.50 AS Decimal(18, 2)), 21902000, 15)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (39, N'KC-5.4-002', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'H', CAST(5.40 AS Decimal(18, 2)), 64431000, 13)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (40, N'KC-5.4-003', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), 67166000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (41, N'KC-5.4-004', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), 68568000, 5)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (42, N'KC-5.4-005', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'E', CAST(5.40 AS Decimal(18, 2)), 68568000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (43, N'KC-5.4-006', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), 67166000, 10)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (44, N'KC-5.4-007', CAST(1.00 AS Decimal(18, 2)), N'VS2', N'EX', N'F', CAST(5.40 AS Decimal(18, 2)), 67166000, 20)
INSERT [dbo].[Diamonds] ([DiamondID], [ProductID], [Carat], [Clarity], [Cut], [Color], [DiameterMM], [BasePrice], [Quantity]) VALUES (45, N'KC-5.4-008', CAST(1.00 AS Decimal(18, 2)), N'VS1', N'EX', N'H', CAST(5.40 AS Decimal(18, 2)), 67116000, 14)
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

INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (1, 1, N'admin@example.com', N'Admin User', N'0912345678', N'admin', N'123', N'123 Admin St', 100, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (2, 2, N'manager@example.com', N'Manager User', N'0987654321', N'manager', N'123', N'456 Manager Ave', 200, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (3, 3, N'member@example.com', N'Member User', N'0915666777', N'member', N'123', N'789 Member Blvd', 300, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (4, 4, N'delivery@example.com', N'Delivery User', N'0999888777', N'delivery', N'123', N'321 Delivery Dr', 400, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (5, 5, N'staff@example.com', N'Staff User', N'0911122333', N'staff', N'123', N'654 Staff Ln', 500, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (6, 3, N'kiettuantranle@gmail.com', N'', N'', N'kiettuantranle', N'123', N'', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (7, 3, N'hungcao@gmail.com', N'Nguyễn Trần Minh Hưng', N'', N'hungcao', N'123', N'44 Cao Lỗ p.5 q8', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (8, 3, N'khoanguyen@gmail.com', N'', N'', N'nguyendangkhoa', N'123', N'', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (9, 3, N'minhtuan22@gmail.com', N'Nguyễn Minh Tuấn', N'', N'minhtuanng', N'123', N'33 CMT8 P.4 Q.Tân Bình', 300, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (10, 3, N'hoaithanh283@gmail.com', N'', N'', N'hoaithanh', N'12345', N'', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (15, 3, N'minhhai123@gmail.com', N'Trần Minh Hải', N'', N'haine', N'@8321', N'22 Vĩnh Viễn p3 q10', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (16, 3, N'hieuleban@gmail.com', N'Lê Thanh Hiếu', N'', N'Thanh Lê', N'32138128312@', N'1231/03 Hòa hưng p3 q.10', 1000, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (17, 4, N'linhle002@gmail.com', N'Trần Thị Trúc Linh', N'', N'Trúc Linh', N'linhxinhdep123', N'10 Hàng Xanh p10 q. Bình Thạnh', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (19, 4, N'hanhtay@gmail.com', N'Lê Đình Nguyên', N'', N'Nguyên', N'nguyenhehuoc00', N'', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (21, 1, N'longnguyen@gmail.com', N'Nguyễn Hoàng Long', N'', N'Anh Long', N'longne', N'', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (22, 2, N'vinhht@gmail.com', N'Huỳnh Thanh Vinh', N'', N'Vinh Huỳnh', N'vinhht123', N'', 0, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (23, 3, N'tranglocxua@gmail.com', N'Ngô Thanh Trang', N'', N'trangjaeh', N'2301@trang', N'', 0, 0)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (24, 3, N'jenneni@gmail.com', N'Jenny Mias', N'', N'jenne1', N'0193je', N'', 20000, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (25, 1, N'kiet@gmailcom', N'Nguyễn Hào Kiệt', N'', N'kietuwy', N'2310kietne', N'', 10, 0)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (26, 4, N'hejau@gmailcom', N'Nguyễn Minh Tài', N'', N'tainguyen10', N'tainguyen123', N'', 0, 0)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (27, 2, N'phuonglinh219@gmail.com', N'Hà Phương Linh', N'', N'linhkkaka', N'12345678', N'', 0, 0)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (28, 3, N'vuongne@gmailcom', N'Trần Đức Vương', N'', N'vuongne', N'12345', N'', 2000, 1)
INSERT [dbo].[Users] ([UserId], [RoleId], [Email], [FullName], [NumberPhone], [Username], [Password], [Address], [LoyaltyPoints], [IsActive]) VALUES (29, 5, N'hung@gmail.com', N'Nguyễn Tuấn Hùng', N'', N'hung442', N'123456789', N'', 0, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (1, 1, CAST(200000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-15T12:34:56.1230000' AS DateTime2), N'Giao hàng nhanh chóng', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (2, 2, CAST(370200000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2023-05-16T14:21:22.4560000' AS DateTime2), N'Yêu cầu gói quà', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (3, 3, CAST(1854000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-17T16:45:33.7890000' AS DateTime2), N'Liên hệ trước khi giao', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (4, 4, CAST(2310000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-18T11:12:12.0120000' AS DateTime2), N'Khách hàng VIP', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (5, 1, CAST(22000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-19T10:01:44.3210000' AS DateTime2), N'Địa chỉ giao hàng mới', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (6, 1, CAST(2300000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-20T17:23:55.6540000' AS DateTime2), N'Ưu đãi đặc biệt', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (7, 2, CAST(380000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-21T09:30:11.9870000' AS DateTime2), N'Sản phẩm cao cấp', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (8, 3, CAST(12000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2023-05-22T08:45:22.8760000' AS DateTime2), N'Yêu cầu giao vào buổi tối', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (9, 4, CAST(7530000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-05-23T07:12:33.7650000' AS DateTime2), N'Khuyến mãi sinh nhật', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (10, 1, CAST(203100000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2023-05-24T06:23:44.6540000' AS DateTime2), N'Tặng kèm phiếu giảm giá', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (11, 3, CAST(3000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T13:43:34.5470809' AS DateTime2), N'', N'')
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (15, 7, CAST(6000000.00 AS Decimal(18, 2)), N'Shipping', CAST(N'2024-07-15T14:58:27.5026049' AS DateTime2), N'', N'')
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (16, 6, CAST(11421000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2024-07-17T15:28:49.8331852' AS DateTime2), N'', N'')
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (17, 10, CAST(111045000.00 AS Decimal(18, 2)), N'Ordering', CAST(N'2024-07-20T14:11:31.2950739' AS DateTime2), N'', N'')
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (18, 3, CAST(103210000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-01-01T00:00:00.0000000' AS DateTime2), N'', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (20, 8, CAST(203000000.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2023-07-13T00:00:00.0000000' AS DateTime2), N'', N'Shipper liên lạc không được')
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (21, 8, CAST(24000000.00 AS Decimal(18, 2)), N'Pending', CAST(N'2024-04-18T00:00:00.0000000' AS DateTime2), N'', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (22, 8, CAST(8000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2024-03-19T00:00:00.0000000' AS DateTime2), N'', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (23, 16, CAST(180321900.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2023-01-18T00:00:00.0000000' AS DateTime2), N'', N'Không chịu nhận hàng')
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (24, 24, CAST(2900000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2024-01-22T00:00:00.0000000' AS DateTime2), N'', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (26, 28, CAST(25000000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2024-06-21T00:00:00.0000000' AS DateTime2), N'', NULL)
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (27, 28, CAST(13400000.00 AS Decimal(18, 2)), N'Cancel', CAST(N'2024-03-19T00:00:00.0000000' AS DateTime2), N'', N'Shipper không liên lạc được')
INSERT [dbo].[Orders] ([OrderId], [UserID], [TotalPrice], [Status], [OrderDate], [OrderNote], [CancelReason]) VALUES (28, 28, CAST(11421000.00 AS Decimal(18, 2)), N'Completed', CAST(N'2023-08-01T00:00:00.0000000' AS DateTime2), N'', NULL)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) VALUES (N'OD-001', 15, N'N-001', N'Nhẫn đính đá CZ vàng 10K Barony N W', 3000000, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) VALUES (N'OD-002', 16, N'KC-3.6-003', N'Kim cương viên GIA 3.6ly G VS1 EX', 11421000, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) VALUES (N'OD-003', 17, N'KC-3.6-002', N'Kim cương viên GIA 3.6ly G VS2 EX', 11045000, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) VALUES (N'OD-004', 17, N'N-001', N'Nhẫn đính đá CZ vàng 10K Barony N W', 3000000, 10)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) VALUES (N'OD-005', 26, N'DC-001', N'Dây chuyền Vàng Trắng Ý 18K - Elegance Radiance', 25000000, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) VALUES (N'OD-006', 28, N'KC-3.6-003', N'Kim cương viên GIA 3.6ly G VS1 EX', 11421000, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) VALUES (N'OD-007', 21, N'DC-003', N'Dây chuyền Vàng Trắng Ý 18K - Eternal Sparkle', 24000000, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailId], [OrderId], [ProductId], [ProductName], [UnitPrice], [Quantity]) VALUES (N'OD-008', 27, N'KC-4.5-003', N'Kim cương viên GIA 4.5ly F VS2 EX', 13400000, 1)
GO
SET IDENTITY_INSERT [dbo].[JewelrySizes] ON 

INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (1, 1, 10, 50)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (2, 2, 11, 35)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (3, 3, 12, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (4, 1, 11, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (5, 1, 12, 10)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (6, 1, 13, 4)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (7, 1, 15, 5)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (8, 1, 20, 8)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (9, 1, 17, 5)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (10, 2, 17, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (11, 2, 15, 17)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (12, 2, 18, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (13, 2, 13, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (14, 2, 14, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (15, 3, 10, 13)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (16, 3, 12, 40)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (17, 3, 17, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (18, 3, 18, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (19, 3, 16, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (20, 3, 14, 22)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (21, 22, 10, 23)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (22, 22, 13, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (23, 22, 11, 10)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (24, 22, 12, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (25, 22, 17, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (26, 22, 15, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (27, 24, 10, 11)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (28, 24, 11, 13)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (29, 24, 14, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (30, 24, 15, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (31, 24, 16, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (32, 24, 17, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (33, 24, 18, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (34, 25, 10, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (35, 25, 11, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (36, 25, 12, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (37, 25, 13, 11)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (38, 25, 14, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (39, 25, 20, 3)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (40, 26, 10, 4)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (41, 26, 11, 40)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (42, 26, 12, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (43, 26, 13, 33)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (44, 26, 15, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (45, 26, 16, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (46, 26, 20, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (47, 27, 11, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (48, 27, 12, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (49, 27, 13, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (50, 27, 14, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (51, 27, 16, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (52, 27, 18, 22)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (53, 27, 20, 13)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (54, 11, 0, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (55, 13, 0, 15)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (56, 14, 0, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (57, 18, 0, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (58, 19, 0, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (59, 21, 0, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (60, 28, 0, 29)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (61, 29, 0, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (62, 30, 0, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (63, 31, 0, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (64, 32, 0, 40)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (65, 33, 0, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (66, 34, 0, 23)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (67, 35, 0, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (68, 36, 0, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (69, 37, 0, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (70, 38, 0, 30)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (71, 39, 0, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (72, 40, 0, 20)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (73, 41, 0, 23)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (74, 42, 0, 38)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (75, 43, 0, 80)
INSERT [dbo].[JewelrySizes] ([JewelrySizeID], [JewelryID], [Size], [Quantity]) VALUES (76, 44, 0, 40)
SET IDENTITY_INSERT [dbo].[JewelrySizes] OFF
GO
