namespace Tesseract_OCR_App.Controllers;

 public class OcrModel
{
    public String DestinationLanguage { get; set; }
    public IFormFile Image { get; set; }
}