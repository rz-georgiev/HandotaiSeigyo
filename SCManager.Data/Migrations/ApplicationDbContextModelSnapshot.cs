﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCManager.Data;

namespace SCManager.Data.Migrations
{
    [DbContext(typeof(SCManagerDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "c5fb4568-51c6-43ab-8050-a5642eb9ac44",
                            ConcurrencyStamp = "55309049-c467-42fd-9223-e221b7c3b61a",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                            RoleId = "c5fb4568-51c6-43ab-8050-a5642eb9ac44"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SCManager.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ImageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("LastUpdatedByUserId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac202f5b-66d9-4989-a1a2-72e632a19e98",
                            CreatedDateTime = new DateTime(2020, 6, 1, 14, 57, 16, 395, DateTimeKind.Unspecified).AddTicks(9967),
                            Email = "scmanager_test@mail.com",
                            EmailConfirmed = true,
                            IsBanned = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "SCMANAGER_TEST@MAIL.COM",
                            NormalizedUserName = "SCMANAGER_TEST@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEM9A4bvt/Ci2fC2r5Si1p2dEX8/v8/svgQqI1rqocSOUcWqgfzD8A8OGlpU/6qiZbQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "UFEWI655NFJHSNPMEJBEGWHAJKHAVWIW",
                            TwoFactorEnabled = false,
                            UserName = "scmanager_test@mail.com"
                        });
                });

            modelBuilder.Entity("SCManager.Data.Models.ComponentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastUpdatedByUserId");

                    b.ToTable("ComponentTypes");
                });

            modelBuilder.Entity("SCManager.Data.Models.ComponentTypeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ComponentTypeId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastUpdatedByUserId");

                    b.ToTable("ComponentTypeDetails");
                });

            modelBuilder.Entity("SCManager.Data.Models.StaticSiteInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastUpdatedByUserId");

                    b.ToTable("StaticSiteInfos");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Content = @"<p>SCManager is semiconductors manager application.</p>
<p>Have fun using our product!</p>
<p>&nbsp;</p>
<p>Best regards,</p>
<p>The SCManager team</p>
<p>&nbsp;</p>
<p>This about info is effective as of 2 June 2020.</p>",
                            CreatedByUserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                            CreatedDateTime = new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "About"
                        },
                        new
                        {
                            Id = 6,
                            Content = @"<p>Your privacy is important to us. It is SCManager's policy to respect your privacy regarding any information we may collect from you across our website, <a href=""http://www.scmanager.com/"">http://www.scmanager.com/</a>, and other sites we own and operate.</p>
<p>We only ask for personal information when we truly need it to provide a service to you. We collect it by fair and lawful means, with your knowledge and consent. We also let you know why we&rsquo;re collecting it and how it will be used.</p>
<p>We only retain collected information for as long as necessary to provide you with your requested service. What data we store, we&rsquo;ll protect within commercially acceptable means to prevent loss and theft, as well as unauthorized access, disclosure, copying, use or modification.</p>
<p>We don&rsquo;t share any personally identifying information publicly or with third-parties, except when required to by law.</p>
<p>Our website may link to external sites that are not operated by us. Please be aware that we have no control over the content and practices of these sites, and cannot accept responsibility or liability for their respective privacy policies.</p>
<p>You are free to refuse our request for your personal information, with the understanding that we may be unable to provide you with some of your desired services.</p>
<p>Your continued use of our website will be regarded as acceptance of our practices around privacy and persona
l information. If you have any questions about how we handle user data and personal information, feel free to contact us.</p>
<p>&nbsp;</p>
<p>This policy is effective as of 2 June 2020.</p>
<p>&nbsp;</p>
<p>Best regards,</p>
<p>The SCManager team</p>
<p>&nbsp;</p>
<p><a title=""Generate a free privacy policy"" href=""https://getterms.io"">Privacy Policy created with GetTerms.</a></p>",
                            CreatedByUserId = "7b26038d-1a43-4248-90e1-dc7f0381d7fa",
                            CreatedDateTime = new DateTime(2020, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Name = "Privacy"
                        });
                });

            modelBuilder.Entity("SCManager.Data.Models.UnitMultiplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastUpdatedByUserId");

                    b.ToTable("UnitMultipliers");
                });

            modelBuilder.Entity("SCManager.Data.Models.UserComponentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("ComponentTypeId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastUpdatedByUserId");

                    b.ToTable("UserComponentTypes");
                });

            modelBuilder.Entity("SCManager.Data.Models.UserComponentTypeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentTypeDetailId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastUpdatedByUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UnitMultiplierId")
                        .HasColumnType("int");

                    b.Property<int>("UserComponentTypeId")
                        .HasColumnType("int");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ComponentTypeDetailId");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("LastUpdatedByUserId");

                    b.HasIndex("UnitMultiplierId");

                    b.HasIndex("UserComponentTypeId");

                    b.ToTable("UserComponentTypeDetails");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SCManager.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SCManager.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SCManager.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SCManager.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SCManager.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("SCManager.Data.Models.ApplicationUser", "LastUpdatedByUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedByUserId");
                });

            modelBuilder.Entity("SCManager.Data.Models.ComponentType", b =>
                {
                    b.HasOne("SCManager.Data.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "LastUpdatedByUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedByUserId");
                });

            modelBuilder.Entity("SCManager.Data.Models.ComponentTypeDetail", b =>
                {
                    b.HasOne("SCManager.Data.Models.ComponentType", "ComponentType")
                        .WithMany("Details")
                        .HasForeignKey("ComponentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "LastUpdatedByUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedByUserId");
                });

            modelBuilder.Entity("SCManager.Data.Models.StaticSiteInfo", b =>
                {
                    b.HasOne("SCManager.Data.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "LastUpdatedByUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedByUserId");
                });

            modelBuilder.Entity("SCManager.Data.Models.UnitMultiplier", b =>
                {
                    b.HasOne("SCManager.Data.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "LastUpdatedByUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedByUserId");
                });

            modelBuilder.Entity("SCManager.Data.Models.UserComponentType", b =>
                {
                    b.HasOne("SCManager.Data.Models.ComponentType", "ComponentType")
                        .WithMany()
                        .HasForeignKey("ComponentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "LastUpdatedByUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedByUserId");
                });

            modelBuilder.Entity("SCManager.Data.Models.UserComponentTypeDetail", b =>
                {
                    b.HasOne("SCManager.Data.Models.ComponentTypeDetail", "ComponentTypeDetail")
                        .WithMany()
                        .HasForeignKey("ComponentTypeDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId");

                    b.HasOne("SCManager.Data.Models.ApplicationUser", "LastUpdatedByUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedByUserId");

                    b.HasOne("SCManager.Data.Models.UnitMultiplier", "UnitMultiplier")
                        .WithMany()
                        .HasForeignKey("UnitMultiplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SCManager.Data.Models.UserComponentType", "ComponentType")
                        .WithMany("Details")
                        .HasForeignKey("UserComponentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
