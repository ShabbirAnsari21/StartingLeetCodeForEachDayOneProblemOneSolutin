//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



// Class : A clss is a bluprint of any real entity a class has property and methods
// object : is a real entity | by creating a object we can use any calss's property and methods

// ex

//public class Person
//{
//    public string Name { get; set; }
//    public int Id { get; set; }
//    public void DoSomeWork()
//    {
//        Console.WriteLine("do some work");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Person person = new Person();
//        person.Name = "User";

//        Console.WriteLine(person.Name);

//        Console.WriteLine(person.DoSomeWork);
//    }
//}

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;

namespace ExportToExcel
{
    class Program
    {
        static void MainNew(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var departments = new List<Department>
            {
                new Department
                {
                    Name = "EnergyApp",
                    TotalUsers = 135,
                    AnalysisResponse = 10.37,
                    GetSubDepartment = false,
                    EnergyAnalysisResponse = new List<EnergyAnalysis>
                    {
                        new EnergyAnalysis
                        {
                            Name = "Energiebronnen (opladers)",
                            EnergyAnalysisQuestionResponse = new List<EnergyAnalysisQuestionResponse>
                            {
                                new EnergyAnalysisQuestionResponse { Name = "Werkinhoud / werkvariatie", Response = 93 },
                                new EnergyAnalysisQuestionResponse { Name = "Ontwikkeling en mobiliteit", Response = 71 },
                                new EnergyAnalysisQuestionResponse { Name = "Prestatiefeedback", Response = 36 },
                                new EnergyAnalysisQuestionResponse { Name = "Presteren", Response = 14 },
                                new EnergyAnalysisQuestionResponse { Name = "Steun leidinggevende", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Steun collega’s", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Psychologische veiligheid", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Waardering", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Autonomie", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Inspraak", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Organisatietrots", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Zingeving werk", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Energie privé-situatie", Response = 0 }
                            }
                        },
                        new EnergyAnalysis
                        {
                            Name = "Persoonlijke hulpbronnen",
                            EnergyAnalysisQuestionResponse = new List<EnergyAnalysisQuestionResponse>
                            {
                                new EnergyAnalysisQuestionResponse { Name = "Hoopvol (t.a.v. doelen halen)", Response = 64 },
                                new EnergyAnalysisQuestionResponse { Name = "Optimistisch (positieve kijk)", Response = 57 },
                                new EnergyAnalysisQuestionResponse { Name = "Veerkrachtig (bij tegenslag)", Response = 43 },
                                new EnergyAnalysisQuestionResponse { Name = "Zelfvertrouwen (in je kunnen)", Response = 21 },
                                new EnergyAnalysisQuestionResponse { Name = "Veel coping skills (voor stress)", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Fysiek fit (gezond, energiek)", Response = 21 }
                            }
                        },
                        new EnergyAnalysis
                        {
                            Name = "Persoonlijke kwetsbaarheden",
                            EnergyAnalysisQuestionResponse = new List<EnergyAnalysisQuestionResponse>
                            {
                                new EnergyAnalysisQuestionResponse { Name = "Snel door problemen uit balans", Response = 71 },
                                new EnergyAnalysisQuestionResponse { Name = "Introvert (naar binnen gekeerd)", Response = 64 },
                                new EnergyAnalysisQuestionResponse { Name = "Faalangstig", Response = 14 },
                                new EnergyAnalysisQuestionResponse { Name = "Perfectionistisch", Response = 21 },
                                new EnergyAnalysisQuestionResponse { Name = "Neiging tot werkverslaving", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Onvoldoende assertief", Response = 14 }
                            }
                        },
                        new EnergyAnalysis
                        {
                            Name = "Stressbronnen (ontladers)",
                            EnergyAnalysisQuestionResponse = new List<EnergyAnalysisQuestionResponse>
                            {
                                new EnergyAnalysisQuestionResponse { Name = "Werkhoeveelheid / werktempo", Response = 93 },
                                new EnergyAnalysisQuestionResponse { Name = "Taakonduidelijkheid", Response = 86 },
                                new EnergyAnalysisQuestionResponse { Name = "Geestelijke belasting", Response = 36 },
                                new EnergyAnalysisQuestionResponse { Name = "Emotionele belasting", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Samenwerkingsproblemen", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Conflicten", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Intern ongewenst gedrag", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Extern ongewenst gedrag", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Frustraties en ergernissen", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Toekomstonzekerheid", Response = 14 },
                                new EnergyAnalysisQuestionResponse { Name = "Verloop personeel", Response = 7 },
                                new EnergyAnalysisQuestionResponse { Name = "Werk-privé verstoring", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Stress privé-situatie", Response = 7 }
                            }
                        }
                    }
                },
                new Department
                {
                    Name = "IT",
                    TotalUsers = 31,
                    AnalysisResponse = 6.45,
                    GetSubDepartment = true,
                    EnergyAnalysisResponse = new List<EnergyAnalysis>
                    {
                        new EnergyAnalysis
                        {
                            Name = "Energiebronnen (opladers)",
                            EnergyAnalysisQuestionResponse = new List<EnergyAnalysisQuestionResponse>
                            {
                                new EnergyAnalysisQuestionResponse { Name = "Werkinhoud / werkvariatie", Response = 100 },
                                new EnergyAnalysisQuestionResponse { Name = "Ontwikkeling en mobiliteit", Response = 100 },
                                new EnergyAnalysisQuestionResponse { Name = "Prestatiefeedback", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Presteren", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Steun leidinggevende", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Steun collega’s", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Psychologische veiligheid", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Waardering", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Autonomie", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Inspraak", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Organisatietrots", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Zingeving werk", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Energie privé-situatie", Response = 0 }
                            }
                        },
                        new EnergyAnalysis
                        {
                            Name = "Persoonlijke hulpbronnen",
                            EnergyAnalysisQuestionResponse = new List<EnergyAnalysisQuestionResponse>
                            {
                                new EnergyAnalysisQuestionResponse { Name = "Hoopvol (t.a.v. doelen halen)", Response = 100 },
                                new EnergyAnalysisQuestionResponse { Name = "Optimistisch (positieve kijk)", Response = 100 },
                                new EnergyAnalysisQuestionResponse { Name = "Veerkrachtig (bij tegenslag)", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Zelfvertrouwen (in je kunnen)", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Veel coping skills (voor stress)", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Fysiek fit (gezond, energiek)", Response = 0 }
                            }
                        },
                        new EnergyAnalysis
                        {
                            Name = "Persoonlijke kwetsbaarheden",
                            EnergyAnalysisQuestionResponse = new List<EnergyAnalysisQuestionResponse>
                            {
                                new EnergyAnalysisQuestionResponse { Name = "Snel door problemen uit balans", Response = 100 },
                                new EnergyAnalysisQuestionResponse { Name = "Introvert (naar binnen gekeerd)", Response = 100 },
                                new EnergyAnalysisQuestionResponse { Name = "Faalangstig", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Perfectionistisch", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Neiging tot werkverslaving", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Onvoldoende assertief", Response = 0 }
                            }
                        },
                        new EnergyAnalysis
                        {
                            Name = "Stressbronnen (ontladers)",
                            EnergyAnalysisQuestionResponse = new List<EnergyAnalysisQuestionResponse>
                            {
                                new EnergyAnalysisQuestionResponse { Name = "Werkhoeveelheid / werktempo", Response = 100 },
                                new EnergyAnalysisQuestionResponse { Name = "Taakonduidelijkheid", Response = 100 },
                                new EnergyAnalysisQuestionResponse { Name = "Geestelijke belasting", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Emotionele belasting", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Samenwerkingsproblemen", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Conflicten", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Intern ongewenst gedrag", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Extern ongewenst gedrag", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Frustraties en ergernissen", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Toekomstonzekerheid", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Verloop personeel", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Werk-privé verstoring", Response = 0 },
                                new EnergyAnalysisQuestionResponse { Name = "Stress privé-situatie", Response = 0 }
                            }
                        }
                    }
                }
            };

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Energy Analysis");

                int row = 1;
                int col = 1;

                // Add headers
                worksheet.Cells[row, col].Value = "Organisatorische eenheid";
                worksheet.Cells[row, col + 1].Value = "Gebruikers";
                worksheet.Cells[row, col + 2].Value = "Respons laatste maand";
                col += 3;

                // Add headers for each category
                var categories = departments[0].EnergyAnalysisResponse;
                foreach (var category in categories)
                {
                    int startCol = col;
                    foreach (var response in category.EnergyAnalysisQuestionResponse)
                    {
                        worksheet.Cells[row + 1, col].Value = response.Name;
                        col++;
                    }
                    worksheet.Cells[row, startCol, row, col - 1].Merge = true;
                    worksheet.Cells[row, startCol].Value = category.Name;
                    worksheet.Cells[row, startCol, row, col - 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[row, startCol, row, col - 1].Style.Fill.BackgroundColor.SetColor(Color.Red);
                    worksheet.Cells[row, startCol, row, col - 1].Style.Font.Color.SetColor(Color.White);
                }

                row += 2;
                col = 1;

                // Add data for each department
                foreach (var department in departments)
                {
                    worksheet.Cells[row, col].Value = department.Name;
                    worksheet.Cells[row, col + 1].Value = department.TotalUsers;
                    worksheet.Cells[row, col + 2].Value = department.AnalysisResponse;
                    col += 3;

                    foreach (var analysis in department.EnergyAnalysisResponse)
                    {
                        foreach (var response in analysis.EnergyAnalysisQuestionResponse)
                        {
                            worksheet.Cells[row, col].Value = response.Response;
                            col++;
                        }
                    }

                    row++;
                    col = 1; // Reset column for the next department
                }

                // Save the file to a specific location
                string exeDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                string fileName = "EnergyApp_Stressbronnen.xlsx";
                string filePath = Path.Combine(exeDirectory, fileName);
                var file = new FileInfo(filePath);
                package.SaveAs(file);

                Console.WriteLine("Excel file created successfully at " + filePath);
            }
        }

        public class Department
        {
            public string Name { get; set; }
            public int TotalUsers { get; set; }
            public double AnalysisResponse { get; set; }
            public bool GetSubDepartment { get; set; }
            public List<EnergyAnalysis> EnergyAnalysisResponse { get; set; }
        }

        public class EnergyAnalysis
        {
            public string Name { get; set; }
            public List<EnergyAnalysisQuestionResponse> EnergyAnalysisQuestionResponse { get; set; }
        }

        public class EnergyAnalysisQuestionResponse
        {
            public string Name { get; set; }
            public int Response { get; set; }
        }
    }
}
