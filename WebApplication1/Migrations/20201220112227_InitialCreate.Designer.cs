﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Repo;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(JobDbContext))]
    [Migration("20201220112227_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebApplication1.Model.HeytourJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("JobDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Title");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Company = "QUORDATE",
                            Email = "frankhorton@quordate.com",
                            Industry = "Rich",
                            IsActive = true,
                            JobDesc = "Veniam laborum veniam commodo veniam nisi commodo. Culpa elit qui deserunt adipisicing ad dolor proident laboris adipisicing tempor eu. Elit do non occaecat exercitation ullamco deserunt. Aliquip labore consectetur elit id. Voluptate cupidatat dolore eiusmod labore eu. Consectetur ipsum mollit tempor eiusmod id ipsum sit.",
                            Location = "Watchtower, Washington",
                            Picture = "https://i.picsum.photos/id/703/300/150.jpg?hmac=u4EJJhnL7eJiV1Ub0wJ5El9hPvAeZvfIIJuKvVFtNus",
                            PostedOn = new DateTime(2020, 12, 11, 4, 48, 37, 0, DateTimeKind.Unspecified),
                            Title = "Fu Er Dai"
                        },
                        new
                        {
                            Id = 2,
                            Company = "TROPOLIS",
                            Email = "frankhorton@tropolis.com",
                            Industry = "Engineering",
                            IsActive = true,
                            JobDesc = "Pariatur enim labore dolore aliqua voluptate non eiusmod dolor quis quis. Fugiat labore enim laborum labore aliqua occaecat minim ut. Reprehenderit est reprehenderit consectetur do. Nisi qui sint quis culpa velit ea. Commodo veniam sit laborum ipsum in. Cupidatat ullamco voluptate elit et exercitation amet sunt et exercitation voluptate in in nisi velit.",
                            Location = "Concho, Oregon",
                            Picture = "https://i.picsum.photos/id/621/300/150.jpg?hmac=_1HUfgf2hdXT2zc6zC1O3MsCTnCa9B_uZsBbLu7LXis",
                            PostedOn = new DateTime(2020, 12, 11, 5, 43, 37, 0, DateTimeKind.Unspecified),
                            Title = "Project Engineer"
                        },
                        new
                        {
                            Id = 3,
                            Company = "ACIUM",
                            Email = "frankhorton@acium.com",
                            Industry = "Finance",
                            IsActive = true,
                            JobDesc = "Proident sit nulla id Lorem laboris qui irure occaecat. Labore eu minim fugiat nisi ea sunt velit pariatur officia consectetur ea proident veniam tempor. Elit do cupidatat dolor elit.",
                            Location = "Cliff, Federated States Of Micronesia",
                            Picture = "https://i.picsum.photos/id/1078/300/150.jpg?hmac=AK5BwU38WcegZssja9EiCB9xd7tIROT5JbYCPZvCwsY",
                            PostedOn = new DateTime(2020, 10, 7, 8, 11, 37, 0, DateTimeKind.Unspecified),
                            Title = "Corporate Advisory"
                        },
                        new
                        {
                            Id = 4,
                            Company = "ANDERSHUN",
                            Email = "frankhorton@andershun.com",
                            Industry = "IT",
                            IsActive = false,
                            JobDesc = "Nostrud in fugiat consequat et voluptate pariatur aliquip in quis velit eiusmod. Do in commodo aliquip id exercitation veniam sunt. Nulla dolore ipsum elit veniam ut et et veniam aliqua. Ea Lorem veniam proident aliqua elit elit eiusmod sunt in elit nisi sint.",
                            Location = "Websterville, Virgin Islands",
                            Picture = "https://i.picsum.photos/id/177/300/150.jpg?hmac=nPEKiWjgBnDbL-NSZ-1JyRiF5I18o4p-JkO-HTlkhTE",
                            PostedOn = new DateTime(2020, 11, 12, 2, 44, 0, 0, DateTimeKind.Unspecified),
                            Title = "Senior Software Engineer"
                        },
                        new
                        {
                            Id = 5,
                            Company = "QUARMONY",
                            Email = "frankhorton@quarmony.com",
                            Industry = "Marketing",
                            IsActive = false,
                            JobDesc = "Sunt exercitation duis nostrud culpa Lorem adipisicing deserunt fugiat pariatur ipsum laboris consequat quis velit. Ea commodo anim Lorem laborum cupidatat deserunt aliqua. Adipisicing velit nostrud ipsum proident id consequat aliquip nisi eu nostrud dolor. Culpa nulla sunt aliquip do voluptate ex elit elit commodo nostrud occaecat proident amet. Esse commodo consectetur est labore esse duis sunt labore nulla culpa cillum culpa ex sint. Enim fugiat proident laboris magna laboris est excepteur labore ad non labore ut.",
                            Location = "Clarence, Indiana",
                            Picture = "https://i.picsum.photos/id/296/300/150.jpg?hmac=MfZDQr0akcTtCtMjO0HsOGdgOXM1GDPJFfstK2nphYY",
                            PostedOn = new DateTime(2020, 5, 21, 5, 47, 12, 0, DateTimeKind.Unspecified),
                            Title = "Marketing Executive"
                        },
                        new
                        {
                            Id = 6,
                            Company = "UNQ",
                            Email = "frankhorton@unq.com",
                            Industry = "IT",
                            IsActive = true,
                            JobDesc = "Officia incididunt ad id laborum aliqua laboris labore amet irure duis et ex consequat elit. Dolore ut consectetur eiusmod deserunt laborum non consectetur magna est incididunt nisi eu magna eiusmod. Do ad dolore adipisicing consectetur incididunt veniam sit cillum. Ullamco exercitation Lorem eiusmod esse minim Lorem veniam aliquip culpa.",
                            Location = "Sattley, Pennsylvania",
                            Picture = "https://i.picsum.photos/id/764/300/150.jpg?hmac=E9CZODHlJdH46z1XK3r5W4FI1XtFUI6bGLmp8Nu060Q",
                            PostedOn = new DateTime(2020, 4, 23, 4, 19, 40, 0, DateTimeKind.Unspecified),
                            Title = "Test Analyst"
                        },
                        new
                        {
                            Id = 7,
                            Company = "CAXT",
                            Email = "frankhorton@caxt.com",
                            Industry = "Education",
                            IsActive = false,
                            JobDesc = "Ea nostrud reprehenderit dolore magna duis Lorem qui deserunt ipsum nisi nulla voluptate non. Sunt id reprehenderit nulla officia consequat aute incididunt ut excepteur occaecat excepteur incididunt. Voluptate non nostrud enim proident incididunt commodo culpa enim incididunt ut est sint labore magna. Ipsum aliqua consectetur nostrud laborum minim velit.",
                            Location = "Hoagland, Oklahoma",
                            Picture = "https://i.picsum.photos/id/915/300/150.jpg?hmac=gHfv_JAFqDL7lQRpAkYZBBwHkirJDaTJ1pB4e0wBrsw",
                            PostedOn = new DateTime(2020, 4, 24, 2, 43, 9, 0, DateTimeKind.Unspecified),
                            Title = "Teacher Aide"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
