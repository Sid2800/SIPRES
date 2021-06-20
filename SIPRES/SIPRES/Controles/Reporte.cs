using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPRES.Controles
{
    class Reporte
    {
        public void A_pdf(String archivo, DataGridView GRID)
        {

            try
            {
                Document PDF = new Document(PageSize.LETTER);
                string fecha = DateTime.Now.ToShortDateString();

                PdfWriter escritura = PdfWriter.GetInstance(PDF, new FileStream(archivo, FileMode.Create));

                // Metadatos
                PDF.AddTitle("");
                PDF.AddCreator("SIFICOP");
                PDF.Open();

                // Insertanto la tabla que iria dentro de nuestro archivo PDF
                PdfPTable tabla = new PdfPTable(GRID.ColumnCount);
                tabla.DefaultCell.Padding = 3;

                // Establecendo el formato de la tabla, ancho de las columnas, Borde Alineacion
                tabla.SetWidths(AnchuraColum(GRID));
                tabla.WidthPercentage = 100;
                tabla.DefaultCell.BorderWidth = 1;
                tabla.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

                // Insertar el encabezado de la tabla exportada
                for (int i = 0; i < GRID.ColumnCount; i++)
                {
                    tabla.AddCell(new Phrase(GRID.Columns[i].HeaderText, FontFactory.GetFont("ARIAL", 8, iTextSharp.text.Font.BOLD)));
                }


                //Ciclos para llenar al grueso de las tados, in ciclo por fila y otro por las columnas de cada fila XD
                for (int i = 0; i < GRID.Rows.Count; i++)
                {
                    for (int j = 0; j < GRID.ColumnCount; j++)
                    {
                        if (GRID[j, i].Value != null)
                        {
                            tabla.AddCell(new Phrase(GRID[j, i].Value.ToString(),
                                FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
                        }
                    }
                    tabla.CompleteRow();
                }

                // Creando el titulo

                Paragraph Titulo = new Paragraph("Sistema Financiero Cooperativista ",
                    FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.BOLD))
                {
                    Alignment = Element.ALIGN_CENTER
                };


                // Creando Mensaje de Despedida
                Paragraph Ultimalinea = new Paragraph("::::::::::::::: Fin del reporte :::::::::::::::",
                    FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.ITALIC))
                {
                    Alignment = Element.ALIGN_CENTER
                };

                // Fecha de creacion del Reporte

                Paragraph FechaReporte = new Paragraph("Fecha: " + fecha,
                    FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.ITALIC))
                {
                    Alignment = Element.ALIGN_LEFT

                };



                iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance(Properties.Resources.Sipres_logo,
                    System.Drawing.Imaging.ImageFormat.Png);

                Logo.ScaleAbsoluteWidth(48);
                Logo.ScaleAbsoluteHeight(48);
                Logo.SetAbsolutePosition(PDF.PageSize.Width - 36f - 540f, PDF.PageSize.Height - 36f - 30f);

                iTextSharp.text.Image Sificcop = iTextSharp.text.Image.GetInstance(Properties.Resources.Sipres_logo,
                   System.Drawing.Imaging.ImageFormat.Png);

                Sificcop.ScaleAbsoluteWidth(72);
                Sificcop.ScaleAbsoluteHeight(24);
                Sificcop.SetAbsolutePosition(PDF.PageSize.Width - 36f - 72f, PDF.PageSize.Height - 36f - 30f);




                // Agreganndo los objetos Creados a Reporte
                PDF.Add(Logo);
                PDF.Add(Sificcop);
                PDF.Add(Titulo);
                PDF.Add(Chunk.NEWLINE);
                PDF.Add(tabla);
                PDF.Add(Chunk.NEWLINE);

                PDF.Add(Chunk.NEWLINE);

                PDF.Add(Ultimalinea);
                PDF.Add(Chunk.NEWLINE);
                PDF.Add(FechaReporte);

                // const alto = () => MessageBox.Show("Gato con botas");

                // Ultimas inteacciones con el reporte, cerramos la edicion; y iniciamos el archivo
                PDF.Close();
                Process.Start(archivo);

            }
            catch (Exception error)//( error)
            {
                MessageBox.Show(error.Message, "Error en el proceso");
            }
        }

        //public void comprobante_deposito(string directorio, Comprobante_modelo comprobante)
        //{


        //    try
        //    {
        //        Document PDF = new Document(PageSize.A6);
        //        string fecha = DateTime.Now.ToShortDateString();

        //        PdfWriter escritura = PdfWriter.GetInstance(PDF, new FileStream(directorio, FileMode.Create));

        //        // Metadatos
        //        PDF.AddTitle("COMPROBANTE DE TRANSSACCION");
        //        PDF.AddCreator("SIFICOP");
        //        PDF.Open();

        //        #region Datos del Cajero
        //        PdfPTable tabla = new PdfPTable(2);
        //        tabla.DefaultCell.Padding = 3;

        //        tabla.WidthPercentage = 100;
        //        tabla.DefaultCell.BorderWidth = 0.0f;
        //        tabla.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

        //        tabla.AddCell(new Phrase("CAJERO ID", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla.AddCell(new Phrase(comprobante.ID_usuario, FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla.CompleteRow();

        //        tabla.AddCell(new Phrase("CAJERO NOMBRE", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla.AddCell(new Phrase(comprobante.Nombre_usuario, FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));

        //        tabla.CompleteRow();
        //        #endregion

        //        #region Datos de la tran
        //        PdfPTable tabla_t = new PdfPTable(2);
        //        tabla_t.DefaultCell.Padding = 3;

        //        tabla_t.WidthPercentage = 100;
        //        tabla_t.DefaultCell.BorderWidth = 0.0f;
        //        tabla_t.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

        //        tabla_t.AddCell(new Phrase("# TRANSACCION", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_t.AddCell(new Phrase(comprobante.N_transaccion.ToString(), FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_t.CompleteRow();

        //        tabla_t.AddCell(new Phrase("FECHA", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_t.AddCell(new Phrase(comprobante.Fecha_trans.ToString(), FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_t.CompleteRow();

        //        tabla_t.AddCell(new Phrase("DESCRIPCION", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_t.AddCell(new Phrase(comprobante.Descripcion, FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_t.CompleteRow();

        //        tabla_t.AddCell(new Phrase("MONTO", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_t.AddCell(new Phrase(comprobante.Monto.ToString(), FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_t.CompleteRow();

        //        tabla_t.AddCell(new Phrase("# CUENTA", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_t.AddCell(new Phrase(comprobante.N_cuenta.ToString(), FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_t.CompleteRow();

        //        tabla_t.AddCell(new Phrase("TIPO CUENTA", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_t.AddCell(new Phrase(comprobante.T_cuenta, FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_t.CompleteRow();

        //        tabla_t.AddCell(new Phrase("AFILIADO", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_t.AddCell(new Phrase(comprobante.Nombre, FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_t.CompleteRow();

        //        tabla_t.AddCell(new Phrase("IDENTIDAD", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_t.AddCell(new Phrase(comprobante.Identidad, FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_t.CompleteRow();
        //        #endregion

        //        #region Datos de la Procedencia
        //        PdfPTable tabla_p = new PdfPTable(2);
        //        tabla_p.DefaultCell.Padding = 3;

        //        tabla_p.WidthPercentage = 100;
        //        tabla_p.DefaultCell.BorderWidth = 0.0f;
        //        tabla_p.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

        //        tabla_p.AddCell(new Phrase("PROCEDENCIA", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_p.AddCell(new Phrase(comprobante.Procedencia, FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_p.CompleteRow();

        //        tabla_p.AddCell(new Phrase("# CUENTA", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_p.AddCell(new Phrase(comprobante.N_cuenta_procedencia.ToString(), FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_p.CompleteRow();

        //        tabla_p.AddCell(new Phrase("NOMBRE ", FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.BOLD)));
        //        tabla_p.AddCell(new Phrase(comprobante.Nombre_p, FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL)));
        //        tabla_p.CompleteRow();



        //        #endregion


        //        // Creando el titulo

        //        Paragraph Titulo = new Paragraph("Sistema Financiero Cooperativista ",
        //            FontFactory.GetFont("ARIAL", 11, iTextSharp.text.Font.BOLD))
        //        {
        //            Alignment = Element.ALIGN_RIGHT
        //        };


        //        // Creando Mensaje de Despedida
        //        Paragraph Ultimalinea = new Paragraph("::::::::::::::::::::::::::::: Fin del reporte :::::::::::::::::::::::::::::",
        //            FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.ITALIC))
        //        {
        //            Alignment = Element.ALIGN_CENTER
        //        };


        //        // Linea Separadora
        //        Paragraph separador = new Paragraph("---------------------------------------------------------------",
        //            FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL))
        //        {
        //            Alignment = Element.ALIGN_CENTER
        //        };

        //        // Linea Firma
        //        Paragraph firma = new Paragraph("Firma ___________________________________",
        //            FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.NORMAL))
        //        {
        //            Alignment = Element.ALIGN_CENTER
        //        };

        //        // Fecha de creacion del Reporte

        //        Paragraph FechaReporte = new Paragraph("Fecha Creacion: " + fecha,
        //            FontFactory.GetFont("ARIAL", 6, iTextSharp.text.Font.ITALIC))
        //        {
        //            Alignment = Element.ANNOTATION

        //        };



        //        iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance(Properties.Resources.Logo_sinletras,
        //            System.Drawing.Imaging.ImageFormat.Png);

        //        Logo.ScaleAbsoluteWidth(48);
        //        Logo.ScaleAbsoluteHeight(48);
        //        Logo.SetAbsolutePosition(PDF.PageSize.Width - 36f - 250f, PDF.PageSize.Height - 36f - 30f);

        //        iTextSharp.text.Image Sificcop = iTextSharp.text.Image.GetInstance(Properties.Resources.sificoop,
        //           System.Drawing.Imaging.ImageFormat.Png);





        //        // Agreganndo los objetos Creados a Reporte
        //        PDF.Add(Logo);

        //        PDF.Add(Titulo);
        //        PDF.Add(Chunk.NEWLINE);

        //        PDF.Add(tabla);
        //        PDF.Add(separador);
        //        PDF.Add(tabla_t);
        //        PDF.Add(separador);
        //        PDF.Add(tabla_p);
        //        PDF.Add(separador);
        //        PDF.Add(Chunk.NEWLINE);
        //        PDF.Add(Chunk.NEWLINE);

        //        PDF.Add(Chunk.NEWLINE);
        //        PDF.Add(Chunk.NEWLINE);
        //        PDF.Add(Chunk.NEWLINE);
        //        PDF.Add(firma);
        //        PDF.Add(Chunk.NEWLINE);
        //        PDF.Add(Chunk.NEWLINE);

        //        PDF.Add(Ultimalinea);

        //        PDF.Add(Chunk.NEWLINE);
        //        PDF.Add(Chunk.NEWLINE);
        //        PDF.Add(FechaReporte);

        //        // const alto = () => MessageBox.Show("Gato con botas");

        //        // Ultimas inteacciones con el reporte, cerramos la edicion; y iniciamos el archivo
        //        PDF.Close();
        //        Process.Start(directorio);

        //    }
        //    catch (Exception error)//( error)
        //    {
        //        MessageBox.Show(error.Message, "Error en el proceso");
        //    }


        //}

        public float[] AnchuraColum(DataGridView dgv)
        {
            float[] anchos = new float[dgv.ColumnCount];
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                anchos[i] = (float)dgv.Columns[i].Width;
            }
            return anchos;
        }

        public void A_excel(DataGridView grid, string ruta)
        {
            if (grid.RowCount > 0)
            {
                string valor;
                DataGridViewRow linea = new DataGridViewRow();
                StreamWriter archivo = new StreamWriter(ruta);

                // escribirmos el encabezado{
                {
                    for (int i = 0; i < grid.Columns.Count; i++)
                    {
                        if (i > 0)
                        {
                            archivo.Write(",");
                        }
                        archivo.Write(grid.Columns[i].HeaderText);
                    }
                    archivo.WriteLine();
                }

                //Escribimos el resto de lineas del grid
                for (int j = 0; j < (grid.Rows.Count); j++)
                {

                    if (j > 0) { archivo.WriteLine(); }
                    linea = grid.Rows[j];
                    for (int i = 0; i < (grid.Columns.Count); i++)
                    {
                        if (i > 0) { archivo.Write(","); }
                        valor = linea.Cells[i].Value.ToString();
                        //reemplazamos las comas con espacios, con el fin de no crear interferencia 
                        //con la separacion de valores que usamos actualmente osea la coma.
                        valor = valor.Replace(',', ' ');
                        // Preguntar no se lo que hace
                        valor = valor.Replace(Environment.NewLine, " ");
                        // Escribimos el valor trabajado y validado
                        archivo.Write(valor);

                    }
                }
                archivo.Close();
            }

            Process.Start(ruta);

        }

    }
}
