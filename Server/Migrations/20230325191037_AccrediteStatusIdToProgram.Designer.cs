﻿// <auto-generated />
using System;
using Accreditation_Watch.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230325191037_AccrediteStatusIdToProgram")]
    partial class AccrediteStatusIdToProgram
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.AWDocument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Progress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AWDocuments");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.AWProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccrediteId")
                        .HasColumnType("int");

                    b.Property<int>("AccrediteStatusId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAccredited")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccrediteId");

                    b.HasIndex("AccrediteStatusId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Programs");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.AWTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssigneeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<int>("ResultTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("DocumentId");

                    b.HasIndex("ResultTypeId");

                    b.HasIndex("TypeId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Accredite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccrediteContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccrediteDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccrediteExpirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccrediteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccrediteNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccrediteStatusId")
                        .HasColumnType("int");

                    b.Property<string>("AccrediteURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccrediteStatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("Accredites");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.AccrediteStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccrediteStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CAD_REJECTED"
                        },
                        new
                        {
                            Id = 2,
                            Name = "SENATE_REJECTED"
                        },
                        new
                        {
                            Id = 3,
                            Name = "REVISION_REQUIRED"
                        },
                        new
                        {
                            Id = 4,
                            Name = "UNDER_REVIEW"
                        },
                        new
                        {
                            Id = 5,
                            Name = "CAD_APPROVED"
                        },
                        new
                        {
                            Id = 6,
                            Name = "PENDING"
                        },
                        new
                        {
                            Id = 7,
                            Name = "HEA_APPROVED"
                        },
                        new
                        {
                            Id = 8,
                            Name = "HEA_REJECTED"
                        },
                        new
                        {
                            Id = 9,
                            Name = "CAD_APPROVED_WITH_CONDITIONS"
                        },
                        new
                        {
                            Id = 10,
                            Name = "CAD_APPROVED_WITH_CONDITIONS_AND_REVISIONS"
                        },
                        new
                        {
                            Id = 11,
                            Name = "SUBMITTED"
                        },
                        new
                        {
                            Id = 12,
                            Name = "ACCREDITED"
                        },
                        new
                        {
                            Id = 13,
                            Name = "DENIED"
                        },
                        new
                        {
                            Id = 14,
                            Name = "NOT_APPLICABLE"
                        },
                        new
                        {
                            Id = 15,
                            Name = "UNDER_INTERNAL_EVALUATION"
                        },
                        new
                        {
                            Id = 16,
                            Name = "EVALUATED"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.AccrediteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccrediteTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Accredited"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Provisional"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Denied"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Withdrawn"
                        },
                        new
                        {
                            Id = 5,
                            Name = "NotApplicable"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer Science",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mathematics",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Physics",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Chemistry",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Biology",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "English",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "History",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 8,
                            Name = "Philosophy",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 9,
                            Name = "Psychology",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sociology",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 11,
                            Name = "Economics",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 12,
                            Name = "Finance",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 13,
                            Name = "Management",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 14,
                            Name = "Marketing",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 15,
                            Name = "Accounting",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 16,
                            Name = "Mechanical Engineering",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 17,
                            Name = "Electrical Engineering",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 18,
                            Name = "Civil Engineering",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 19,
                            Name = "Chemical Engineering",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 20,
                            Name = "Computer Engineering",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 21,
                            Name = "Nursing",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 22,
                            Name = "Health Science",
                            SchoolId = 1
                        },
                        new
                        {
                            Id = 23,
                            Name = "Health Administration",
                            SchoolId = 1
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.PendingImplimentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PendingImplimentations");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.ResultType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResultTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pass"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fail"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Not_Applicable"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Developer"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "School of Business"
                        },
                        new
                        {
                            Id = 2,
                            Name = "School of Education"
                        },
                        new
                        {
                            Id = 3,
                            Name = "School of Engineering"
                        },
                        new
                        {
                            Id = 4,
                            Name = "School of Health Sciences"
                        },
                        new
                        {
                            Id = 5,
                            Name = "School of Humanities and Social Sciences"
                        },
                        new
                        {
                            Id = 6,
                            Name = "School of Natural Sciences"
                        },
                        new
                        {
                            Id = 7,
                            Name = "School of Nursing"
                        },
                        new
                        {
                            Id = 8,
                            Name = "School of Pharmacy"
                        },
                        new
                        {
                            Id = 9,
                            Name = "School of Public Health"
                        },
                        new
                        {
                            Id = 10,
                            Name = "School of Social Work"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Approved"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rejected"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Expired"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Accreditation"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Internal_Audit"
                        },
                        new
                        {
                            Id = 3,
                            Name = "External_Audit"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Reaccreditation"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.AWProgram", b =>
                {
                    b.HasOne("Accreditation_Watch.Shared.Entities.Accredite", "Accredite")
                        .WithMany()
                        .HasForeignKey("AccrediteId");

                    b.HasOne("Accreditation_Watch.Shared.Entities.AccrediteStatus", "Status")
                        .WithMany()
                        .HasForeignKey("AccrediteStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accreditation_Watch.Shared.Entities.Department", "Department")
                        .WithMany("Programs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accredite");

                    b.Navigation("Department");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.AWTask", b =>
                {
                    b.HasOne("Accreditation_Watch.Shared.Entities.User", "Assignee")
                        .WithMany()
                        .HasForeignKey("AssigneeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accreditation_Watch.Shared.Entities.AWDocument", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accreditation_Watch.Shared.Entities.ResultType", "ResultType")
                        .WithMany()
                        .HasForeignKey("ResultTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accreditation_Watch.Shared.Entities.TaskType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignee");

                    b.Navigation("Document");

                    b.Navigation("ResultType");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Accredite", b =>
                {
                    b.HasOne("Accreditation_Watch.Shared.Entities.AccrediteStatus", "AccrediteStatus")
                        .WithMany()
                        .HasForeignKey("AccrediteStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Accreditation_Watch.Shared.Entities.AccrediteType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccrediteStatus");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Department", b =>
                {
                    b.HasOne("Accreditation_Watch.Shared.Entities.School", "School")
                        .WithMany("Departments")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.User", b =>
                {
                    b.HasOne("Accreditation_Watch.Shared.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Department", b =>
                {
                    b.Navigation("Programs");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.School", b =>
                {
                    b.Navigation("Departments");
                });
#pragma warning restore 612, 618
        }
    }
}
