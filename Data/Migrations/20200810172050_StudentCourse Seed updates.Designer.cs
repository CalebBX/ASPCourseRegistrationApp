﻿// <auto-generated />
using System;
using ASPCourseRegistrationApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPCourseRegistrationApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200810172050_StudentCourse Seed updates")]
    partial class StudentCourseSeedupdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPCourseRegistrationApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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
                            Id = "seeduser1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9aec89f1-bb11-4ef0-87f1-386ea8c070cd",
                            Email = "user1@test.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Adel",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@TEST.COM",
                            NormalizedUserName = "USER1@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIXGdUJIhLcFwwKxFVLbwbRkz49cQJ/kTrvRVb/t4KfPVVXwWRlpgolUIstL1rwDNA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user1@test.com"
                        },
                        new
                        {
                            Id = "seeduser2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f9ef1a33-85d7-4b24-b697-d992a2962cdd",
                            Email = "user2@test.com",
                            EmailConfirmed = true,
                            FirstName = "Sara",
                            LastName = "Rogers",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@TEST.COM",
                            NormalizedUserName = "USER2@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGKNS8iCO6lIvBhOr21HzGwRdDx862G5l6ZbdSlGPNzdxYd81kGfl/1gow/uPEnHqg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user2@test.com"
                        },
                        new
                        {
                            Id = "seeduser3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bf42f4e2-8ba0-45ef-b16e-74519b3b8309",
                            Email = "user3@test.com",
                            EmailConfirmed = true,
                            FirstName = "Pete",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@TEST.COM",
                            NormalizedUserName = "USER3@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEElMvYWGb7l1T8iRi4Gfult4GB2Zu3yzVSzzoQ0ZqGQ3+PvbOiYUBNeEPesKR27SUg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user3@test.com"
                        },
                        new
                        {
                            Id = "seeduser4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4c9024d9-b188-42ce-852a-44cdf449931b",
                            Email = "user4@test.com",
                            EmailConfirmed = true,
                            FirstName = "Jane",
                            LastName = "Write",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER4@TEST.COM",
                            NormalizedUserName = "USER4@TEST.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBRlGTX/+RtbIBI1VCBQ78Ha6mel3BQv1dxbeiTtxfNITpPd7q1TRmuZnnzFD16Lig==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "user4@test.com"
                        });
                });

            modelBuilder.Entity("ASPCourseRegistrationApp.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            CourseCode = "DD101",
                            CourseName = "Intro To Dare-Deviling",
                            EndTime = new DateTime(2020, 8, 10, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = 100,
                            Location = "Granger Building RM340",
                            StartTime = new DateTime(2020, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 101,
                            CourseCode = "CM230",
                            CourseName = "Advanced Criminology",
                            EndTime = new DateTime(2020, 8, 10, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = 101,
                            Location = "Apex Building RM110",
                            StartTime = new DateTime(2020, 8, 10, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 102,
                            CourseCode = "MED502",
                            CourseName = "Infection Diseases",
                            EndTime = new DateTime(2020, 8, 10, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = 102,
                            Location = "Apex Building RM130",
                            StartTime = new DateTime(2020, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 103,
                            CourseCode = "MED120",
                            CourseName = "Medicine and General Smart-Assery",
                            EndTime = new DateTime(2020, 8, 10, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = 102,
                            Location = "Apex Building RM130",
                            StartTime = new DateTime(2020, 8, 10, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 104,
                            CourseCode = "VIL101",
                            CourseName = "Intro To Villany",
                            EndTime = new DateTime(2020, 8, 10, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = 103,
                            Location = "Tech Complex RM20",
                            StartTime = new DateTime(2020, 8, 10, 6, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 105,
                            CourseCode = "VIL203",
                            CourseName = "Inator-Creation and other Evil Inventions",
                            EndTime = new DateTime(2020, 8, 10, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = 103,
                            Location = "Tech Complex RM20",
                            StartTime = new DateTime(2020, 8, 10, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 106,
                            CourseCode = "VIL210",
                            CourseName = "Advanced Platapus Countermeasures",
                            EndTime = new DateTime(2020, 8, 10, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorId = 103,
                            Location = "Tech Complex RM20",
                            StartTime = new DateTime(2020, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ASPCourseRegistrationApp.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FacultyMembers");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            FirstName = "Kick",
                            LastName = "Buttowski"
                        },
                        new
                        {
                            Id = 101,
                            FirstName = "Ace",
                            LastName = "Ventura"
                        },
                        new
                        {
                            Id = 102,
                            FirstName = "Gregory",
                            LastName = "House"
                        },
                        new
                        {
                            Id = 103,
                            FirstName = "Heinz",
                            LastName = "Doofenshmirtz"
                        });
                });

            modelBuilder.Entity("ASPCourseRegistrationApp.Models.StudentCourse", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");
                });

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

            modelBuilder.Entity("ASPCourseRegistrationApp.Models.Course", b =>
                {
                    b.HasOne("ASPCourseRegistrationApp.Models.Faculty", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("ASPCourseRegistrationApp.Models.StudentCourse", b =>
                {
                    b.HasOne("ASPCourseRegistrationApp.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPCourseRegistrationApp.Models.ApplicationUser", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("ASPCourseRegistrationApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ASPCourseRegistrationApp.Models.ApplicationUser", null)
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

                    b.HasOne("ASPCourseRegistrationApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ASPCourseRegistrationApp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
