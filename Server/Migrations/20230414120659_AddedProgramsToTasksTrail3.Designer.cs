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
    [Migration("20230414120659_AddedProgramsToTasksTrail3")]
    partial class AddedProgramsToTasksTrail3
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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

                    b.Property<bool>("IsDeleted")
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<int>("ResultTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("DocumentId");

                    b.HasIndex("ProgramId");

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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccrediteStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "CAD_REJECTED"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "SENATE_REJECTED"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "REVISION_REQUIRED"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "UNDER_REVIEW"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "CAD_APPROVED"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "PENDING"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "HEA_APPROVED"
                        },
                        new
                        {
                            Id = 8,
                            IsDeleted = false,
                            Name = "HEA_REJECTED"
                        },
                        new
                        {
                            Id = 9,
                            IsDeleted = false,
                            Name = "CAD_APPROVED_WITH_CONDITIONS"
                        },
                        new
                        {
                            Id = 10,
                            IsDeleted = false,
                            Name = "CAD_APPROVED_WITH_CONDITIONS_AND_REVISIONS"
                        },
                        new
                        {
                            Id = 11,
                            IsDeleted = false,
                            Name = "SUBMITTED"
                        },
                        new
                        {
                            Id = 12,
                            IsDeleted = false,
                            Name = "ACCREDITED"
                        },
                        new
                        {
                            Id = 13,
                            IsDeleted = false,
                            Name = "DENIED"
                        },
                        new
                        {
                            Id = 14,
                            IsDeleted = false,
                            Name = "NOT_APPLICABLE"
                        },
                        new
                        {
                            Id = 15,
                            IsDeleted = false,
                            Name = "UNDER_INTERNAL_EVALUATION"
                        },
                        new
                        {
                            Id = 16,
                            IsDeleted = false,
                            Name = "EVALUATED"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.AccrediteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccrediteTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Accredited"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Provisional"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Denied"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Withdrawn"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "NotApplicable"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Departments");
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActionResult")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinalState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InitialState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Severity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.PendingImplimentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ResultTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Pass"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Fail"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Not_Applicable"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "User"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Developer"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "School of Business"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "School of Education"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "School of Engineering"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "School of Health Sciences"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "School of Humanities and Social Sciences"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "School of Natural Sciences"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "School of Nursing"
                        },
                        new
                        {
                            Id = 8,
                            IsDeleted = false,
                            Name = "School of Pharmacy"
                        },
                        new
                        {
                            Id = 9,
                            IsDeleted = false,
                            Name = "School of Public Health"
                        },
                        new
                        {
                            Id = 10,
                            IsDeleted = false,
                            Name = "School of Social Work"
                        });
                });

            modelBuilder.Entity("Accreditation_Watch.Shared.Entities.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Accreditation"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Internal_Audit"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "External_Audit"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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

                    b.HasOne("Accreditation_Watch.Shared.Entities.AWProgram", "Program")
                        .WithMany()
                        .HasForeignKey("ProgramId")
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

                    b.Navigation("Program");

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
