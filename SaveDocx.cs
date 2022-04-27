using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Pdf;
using Spire.Doc.Collections;
using System.Drawing;
using DocumentFormat.OpenXml.Presentation;
using Spire.Doc.Fields;
using Document = Spire.Doc.Document;

namespace NguyenMinhTri_20110422_LOGIN_BUOI1
{
    class SaveDocx 
    {


        public void createTable(List<String> header, List<STUDENT> list)
        {

            Document doc = new Document();

            Paragraph paragraph = doc.AddSection().AddParagraph();
            //Slide.Doc.Fields.TextRange text = paragraph.AppendText("\nTrường Đại Học Sư Phạm Kỹ Thuật Thành Phố Hồ Chí Minh\n\n Danh Sách Thông Tin Student\n\n");
            //text.CharacterFormat.Bold = true;
            paragraph.Format.TextAlignment = TextAlignment.Center;
            paragraph.Format.HorizontalAlignment = HorizontalAlignment.Center;
            Spire.Doc.Table table = doc.Sections[0].AddTable(true);
            table.ResetCells(list.Count + 1, header.Count);
            for (int i = 0; i < list.Count + 1; i++)
            {
                for (int j = 0; j < header.Count; j++)
                {
                    table.Rows[i].Cells[j].Width = 150;
                    table.Rows[i].Cells[j].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                }
            }
            TableRow row = table.Rows[0];
            row.IsHeader = true;
            row.Height = 20;
            for (int i = 0; i < header.Count; i++)
            {
                Paragraph p = row.Cells[i].AddParagraph();
                row.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                p.Format.HorizontalAlignment = HorizontalAlignment.Center;
                Spire.Doc.Fields.TextRange TR = p.AppendText(header[i]);
                TR.CharacterFormat.FontName = "Times New Roman";
                TR.CharacterFormat.FontSize = 13;
                TR.CharacterFormat.Bold = true;
            }
            for (int r = 0; r < list.Count; r++)
            {
                row = table.Rows[r + 1];
                row.Height = 80;
                List<string> listString = list[r].convert();
                Paragraph par;
                TextRange tex;
                DocPicture pic;
                for (int i = 0; i < listString.Count; i++)
                {
                    par = row.Cells[i].AddParagraph();
                    tex = par.AppendText(listString[i]); // STT
                    par.Format.HorizontalAlignment = HorizontalAlignment.Center;
                }
                par = row.Cells[7].AddParagraph();
                pic = par.AppendPicture(list[r].pic);
                pic.HorizontalPosition = 0.0F;
                pic.VerticalPosition = 0.0F;
                par.Format.HorizontalAlignment = HorizontalAlignment.Center;
                //Kích thước ảnh
                pic.Width = 80;
                pic.Height = 80;
                pic.TextWrappingStyle = TextWrappingStyle.InFrontOfText;

            }
            doc.SaveToFile("Student_list.doc", Spire.Doc.FileFormat.Doc);
            doc.Close();
        }

    }
}
