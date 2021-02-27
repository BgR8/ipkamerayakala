## AForge.NET kütüphanesini kur
```
using AForge.Video;
```

## IP'yi çağır
`MJPEGStream("ip")`
## Bitmap ile PictureBox'a ata.
```
Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
pictureBox1.Image = bmp;
```

## Başlat butonuyla yayını başlat
```
stream.Start();
```
## Dur butonuyla yayını bitir
```
stream.Stop();
```
