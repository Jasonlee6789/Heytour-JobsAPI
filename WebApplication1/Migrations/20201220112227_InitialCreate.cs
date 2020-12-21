using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Company", "Email", "Industry", "IsActive", "JobDesc", "Location", "Picture", "PostedOn", "Title" },
                values: new object[,]
                {
                    { 1, "QUORDATE", "frankhorton@quordate.com", "Rich", true, "Veniam laborum veniam commodo veniam nisi commodo. Culpa elit qui deserunt adipisicing ad dolor proident laboris adipisicing tempor eu. Elit do non occaecat exercitation ullamco deserunt. Aliquip labore consectetur elit id. Voluptate cupidatat dolore eiusmod labore eu. Consectetur ipsum mollit tempor eiusmod id ipsum sit.", "Watchtower, Washington", "https://i.picsum.photos/id/703/300/150.jpg?hmac=u4EJJhnL7eJiV1Ub0wJ5El9hPvAeZvfIIJuKvVFtNus", new DateTime(2020, 12, 11, 4, 48, 37, 0, DateTimeKind.Unspecified), "Fu Er Dai" },
                    { 2, "TROPOLIS", "frankhorton@tropolis.com", "Engineering", true, "Pariatur enim labore dolore aliqua voluptate non eiusmod dolor quis quis. Fugiat labore enim laborum labore aliqua occaecat minim ut. Reprehenderit est reprehenderit consectetur do. Nisi qui sint quis culpa velit ea. Commodo veniam sit laborum ipsum in. Cupidatat ullamco voluptate elit et exercitation amet sunt et exercitation voluptate in in nisi velit.", "Concho, Oregon", "https://i.picsum.photos/id/621/300/150.jpg?hmac=_1HUfgf2hdXT2zc6zC1O3MsCTnCa9B_uZsBbLu7LXis", new DateTime(2020, 12, 11, 5, 43, 37, 0, DateTimeKind.Unspecified), "Project Engineer" },
                    { 3, "ACIUM", "frankhorton@acium.com", "Finance", true, "Proident sit nulla id Lorem laboris qui irure occaecat. Labore eu minim fugiat nisi ea sunt velit pariatur officia consectetur ea proident veniam tempor. Elit do cupidatat dolor elit.", "Cliff, Federated States Of Micronesia", "https://i.picsum.photos/id/1078/300/150.jpg?hmac=AK5BwU38WcegZssja9EiCB9xd7tIROT5JbYCPZvCwsY", new DateTime(2020, 10, 7, 8, 11, 37, 0, DateTimeKind.Unspecified), "Corporate Advisory" },
                    { 4, "ANDERSHUN", "frankhorton@andershun.com", "IT", false, "Nostrud in fugiat consequat et voluptate pariatur aliquip in quis velit eiusmod. Do in commodo aliquip id exercitation veniam sunt. Nulla dolore ipsum elit veniam ut et et veniam aliqua. Ea Lorem veniam proident aliqua elit elit eiusmod sunt in elit nisi sint.", "Websterville, Virgin Islands", "https://i.picsum.photos/id/177/300/150.jpg?hmac=nPEKiWjgBnDbL-NSZ-1JyRiF5I18o4p-JkO-HTlkhTE", new DateTime(2020, 11, 12, 2, 44, 0, 0, DateTimeKind.Unspecified), "Senior Software Engineer" },
                    { 5, "QUARMONY", "frankhorton@quarmony.com", "Marketing", false, "Sunt exercitation duis nostrud culpa Lorem adipisicing deserunt fugiat pariatur ipsum laboris consequat quis velit. Ea commodo anim Lorem laborum cupidatat deserunt aliqua. Adipisicing velit nostrud ipsum proident id consequat aliquip nisi eu nostrud dolor. Culpa nulla sunt aliquip do voluptate ex elit elit commodo nostrud occaecat proident amet. Esse commodo consectetur est labore esse duis sunt labore nulla culpa cillum culpa ex sint. Enim fugiat proident laboris magna laboris est excepteur labore ad non labore ut.", "Clarence, Indiana", "https://i.picsum.photos/id/296/300/150.jpg?hmac=MfZDQr0akcTtCtMjO0HsOGdgOXM1GDPJFfstK2nphYY", new DateTime(2020, 5, 21, 5, 47, 12, 0, DateTimeKind.Unspecified), "Marketing Executive" },
                    { 6, "UNQ", "frankhorton@unq.com", "IT", true, "Officia incididunt ad id laborum aliqua laboris labore amet irure duis et ex consequat elit. Dolore ut consectetur eiusmod deserunt laborum non consectetur magna est incididunt nisi eu magna eiusmod. Do ad dolore adipisicing consectetur incididunt veniam sit cillum. Ullamco exercitation Lorem eiusmod esse minim Lorem veniam aliquip culpa.", "Sattley, Pennsylvania", "https://i.picsum.photos/id/764/300/150.jpg?hmac=E9CZODHlJdH46z1XK3r5W4FI1XtFUI6bGLmp8Nu060Q", new DateTime(2020, 4, 23, 4, 19, 40, 0, DateTimeKind.Unspecified), "Test Analyst" },
                    { 7, "CAXT", "frankhorton@caxt.com", "Education", false, "Ea nostrud reprehenderit dolore magna duis Lorem qui deserunt ipsum nisi nulla voluptate non. Sunt id reprehenderit nulla officia consequat aute incididunt ut excepteur occaecat excepteur incididunt. Voluptate non nostrud enim proident incididunt commodo culpa enim incididunt ut est sint labore magna. Ipsum aliqua consectetur nostrud laborum minim velit.", "Hoagland, Oklahoma", "https://i.picsum.photos/id/915/300/150.jpg?hmac=gHfv_JAFqDL7lQRpAkYZBBwHkirJDaTJ1pB4e0wBrsw", new DateTime(2020, 4, 24, 2, 43, 9, 0, DateTimeKind.Unspecified), "Teacher Aide" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_Title",
                table: "Jobs",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");
        }
    }
}
