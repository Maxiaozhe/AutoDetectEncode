# AutoDetectEncode
指定範囲のエンコード種別でファイルのエンコードを検出することができます。

## 下記エンコードをデフォルト識別できる
* UTF-8
* UTF-8 with BOM
* UTF-16
* shift_jis
* EUC-JP
* GBK

## 使い方
1. 既定のエンコードで探す
```
 string filePath="c:\test.csv";
 using (FileStream stream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
  {
      byte[] buffer = new byte[stream.Length];
      stream.Read(buffer, 0, (int)stream.Length);
      AutoDetector dector = new AutoDetector();
      Encoding encoder = null;
      string encode = dector.DetectEncoding(buffer, ref encoder);
      MessageBox.Show(encode);
  }
```
2. 限定したエンコードで探す
```
 string filePath="c:\test.csv";
 using (FileStream stream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
  {
      byte[] buffer = new byte[stream.Length];
      stream.Read(buffer, 0, (int)stream.Length);
      string[] targetEncodes={"utf-8","shift-jis"};
      AutoDetector dector = new AutoDetector(targetEncodes);
      Encoding encoder = null;
      string encode = dector.DetectEncoding(buffer, ref encoder);
      MessageBox.Show(encode);
  }
```
