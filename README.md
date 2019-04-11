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
## .Net Framework サポートするエンコード一覧
| CodePage | CodeName                | DisplayName                          |
|----------|-------------------------|--------------------------------------|
| 37       | IBM037                  | IBM EBCDIC (US - カナダ)                |
| 437      | IBM437                  | OEM アメリカ合衆国                          |
| 500      | IBM500                  | IBM EBCDIC (インターナショナル)               |
| 708      | ASMO-708                | アラビア語 (ASMO 708)                     |
| 720      | DOS-720                 | アラビア語 (DOS)                          |
| 737      | ibm737                  | ギリシャ語 (DOS)                          |
| 775      | ibm775                  | バルト言語 (DOS)                          |
| 850      | ibm850                  | 西ヨーロッパ言語 (DOS)                       |
| 852      | ibm852                  | 中央ヨーロッパ言語 (DOS)                      |
| 855      | IBM855                  | OEM キリル                              |
| 857      | ibm857                  | トルコ語 (DOS)                           |
| 858      | IBM00858                | OEM マルチリンガル ラテン I                    |
| 860      | IBM860                  | ポルトガル語  (DOS)                        |
| 861      | ibm861                  | アイスランド語 (DOS)                        |
| 862      | DOS-862                 | ヘブライ語 (DOS)                          |
| 863      | IBM863                  | フランス語 (カナダ) (DOS)                    |
| 864      | IBM864                  | アラビア語 (864)                          |
| 865      | IBM865                  | 北欧 (DOS)                             |
| 866      | cp866                   | キリル言語 (DOS)                          |
| 869      | ibm869                  | ギリシャ語, Modern (DOS)                  |
| 870      | IBM870                  | IBM EBCDIC (多国語ラテン 2)                |
| 874      | windows-874             | タイ語 (Windows)                        |
| 875      | cp875                   | IBM EBCDIC (ギリシャ語 Modern)            |
| 932      | shift_jis               | 日本語 (シフト JIS)                        |
| 936      | gb2312                  | 簡体字中国語 (GB2312)                      |
| 949      | ks_c_5601-1987          | 韓国語                                  |
| 950      | big5                    | 繁体字中国語 (Big5)                        |
| 1026     | IBM1026                 | IBM EBCDIC (トルコ語ラテン 5)               |
| 1047     | IBM01047                | IBM ラテン-1                            |
| 1140     | IBM01140                | IBM EBCDIC (US - カナダ - ヨーロッパ)        |
| 1141     | IBM01141                | IBM EBCDIC (ドイツ - ヨーロッパ)             |
| 1142     | IBM01142                | IBM EBCDIC (デンマーク - ノルウェー - ヨーロッパ)   |
| 1143     | IBM01143                | IBM EBCDIC (フィンランド - スウェーデン - ヨーロッパ) |
| 1144     | IBM01144                | IBM EBCDIC (イタリア - ヨーロッパ)            |
| 1145     | IBM01145                | IBM EBCDIC (スペイン - ヨーロッパ)            |
| 1146     | IBM01146                | IBM EBCDIC (UK - ヨーロッパ)              |
| 1147     | IBM01147                | IBM EBCDIC (フランス - ヨーロッパ)            |
| 1148     | IBM01148                | IBM EBCDIC (インターナショナル - ヨーロッパ)       |
| 1149     | IBM01149                | IBM EBCDIC (アイスランド語 - ヨーロッパ)         |
| 1200     | utf-16                  | Unicode                              |
| 1201     | utf-16BE                | Unicode (Big-Endian)                 |
| 1250     | windows-1250            | 中央ヨーロッパ言語 (Windows)                  |
| 1251     | windows-1251            | キリル言語 (Windows)                      |
| 1252     | Windows-1252            | 西ヨーロッパ言語 (Windows)                   |
| 1253     | windows-1253            | ギリシャ語 (Windows)                      |
| 1254     | windows-1254            | トルコ語 (Windows)                       |
| 1255     | windows-1255            | ヘブライ語 (Windows)                      |
| 1256     | windows-1256            | アラビア語 (Windows)                      |
| 1257     | windows-1257            | バルト言語 (Windows)                      |
| 1258     | windows-1258            | ベトナム語 (Windows)                      |
| 1361     | Johab                   | 韓国語 (Johab)                          |
| 10000    | macintosh               | 西ヨーロッパ言語 (Mac)                       |
| 10001    | x-mac-japanese          | 日本語 (Mac)                            |
| 10002    | x-mac-chinesetrad       | 繁体字中国語 (Mac)                         |
| 10003    | x-mac-korean            | 韓国語 (Mac)                            |
| 10004    | x-mac-arabic            | アラビア語 (Mac)                          |
| 10005    | x-mac-hebrew            | ヘブライ語 (Mac)                          |
| 10006    | x-mac-greek             | ギリシャ語 (Mac)                          |
| 10007    | x-mac-cyrillic          | キリル言語 (Mac)                          |
| 10008    | x-mac-chinesesimp       | 簡体字中国語 (Mac)                         |
| 10010    | x-mac-romanian          | ルーマニア語 (Mac)                         |
| 10017    | x-mac-ukrainian         | ウクライナ語 (Mac)                         |
| 10021    | x-mac-thai              | タイ語 (Mac)                            |
| 10029    | x-mac-ce                | 中央ヨーロッパ言語 (Mac)                      |
| 10079    | x-mac-icelandic         | アイスランド語 (Mac)                        |
| 10081    | x-mac-turkish           | トルコ語 (Mac)                           |
| 10082    | x-mac-croatian          | クロアチア語 (Mac)                         |
| 12000    | utf-32                  | Unicode (UTF-32)                     |
| 12001    | utf-32BE                | Unicode (UTF-32 ビッグ エンディアン)          |
| 20000    | x-Chinese-CNS           | 繁体字中国語 (CNS)                         |
| 20001    | x-cp20001               | TCA 台湾                               |
| 20002    | x-Chinese-Eten          | 繁体字中国語 (Eten)                        |
| 20003    | x-cp20003               | IBM5550 台湾                           |
| 20004    | x-cp20004               | TeleText 台湾                          |
| 20005    | x-cp20005               | Wang 台湾                              |
| 20105    | x-IA5                   | 西ヨーロッパ言語 (IA5)                       |
| 20106    | x-IA5-German            | ドイツ語 (IA5)                           |
| 20107    | x-IA5-Swedish           | スウェーデン語 (IA5)                        |
| 20108    | x-IA5-Norwegian         | ノルウェー語 (IA5)                         |
| 20127    | us-ascii                | US-ASCII                             |
| 20261    | x-cp20261               | T.61                                 |
| 20269    | x-cp20269               | ISO-6937                             |
| 20273    | IBM273                  | IBM EBCDIC (ドイツ)                     |
| 20277    | IBM277                  | IBM EBCDIC (デンマーク - ノルウェー)           |
| 20278    | IBM278                  | IBM EBCDIC (フィンランド - スウェーデン)         |
| 20280    | IBM280                  | IBM EBCDIC (イタリア)                    |
| 20284    | IBM284                  | IBM EBCDIC (スペイン)                    |
| 20285    | IBM285                  | IBM EBCDIC (UK)                      |
| 20290    | IBM290                  | IBM EBCDIC (日本語カタカナ)                 |
| 20297    | IBM297                  | IBM EBCDIC (フランス)                    |
| 20420    | IBM420                  | IBM EBCDIC (アラビア語)                   |
| 20423    | IBM423                  | IBM EBCDIC (ギリシャ語)                   |
| 20424    | IBM424                  | IBM EBCDIC (ヘブライ語)                   |
| 20833    | x-EBCDIC-KoreanExtended | IBM EBCDIC (韓国語 Extended)            |
| 20838    | IBM-Thai                | IBM EBCDIC (タイ語)                     |
| 20866    | koi8-r                  | キリル言語 (KOI8-R)                       |
| 20871    | IBM871                  | IBM EBCDIC (アイスランド語)                 |
| 20880    | IBM880                  | IBM EBCDIC (キリル言語 - ロシア語)            |
| 20905    | IBM905                  | IBM EBCDIC (トルコ語)                    |
| 20924    | IBM00924                | IBM ラテン-1                            |
| 20932    | EUC-JP                  | 日本語 (JIS 0208-1990 および 0212-1990)    |
| 20936    | x-cp20936               | 簡体字中国語 (GB2312-80)                   |
| 20949    | x-cp20949               | 韓国語 Wansung                          |
| 21025    | cp1025                  | IBM EBCDIC (キリル言語 セルビア - ブルガリア)      |
| 21866    | koi8-u                  | キリル言語 (KOI8-U)                       |
| 28591    | iso-8859-1              | 西ヨーロッパ言語 (ISO)                       |
| 28592    | iso-8859-2              | 中央ヨーロッパ言語 (ISO)                      |
| 28593    | iso-8859-3              | ラテン 3 (ISO)                          |
| 28594    | iso-8859-4              | バルト言語 (ISO)                          |
| 28595    | iso-8859-5              | キリル言語 (ISO)                          |
| 28596    | iso-8859-6              | アラビア語 (ISO)                          |
| 28597    | iso-8859-7              | ギリシャ語 (ISO)                          |
| 28598    | iso-8859-8              | ヘブライ語 (ISO-Visual)                   |
| 28599    | iso-8859-9              | トルコ語 (ISO)                           |
| 28603    | iso-8859-13             | エストニア語 (ISO)                         |
| 28605    | iso-8859-15             | ラテン 9 (ISO)                          |
| 29001    | x-Europa                | ヨーロッパ                                |
| 38598    | iso-8859-8-i            | ヘブライ語 (ISO-Logical)                  |
| 50220    | iso-2022-jp             | 日本語 (JIS)                            |
| 50221    | csISO2022JP             | 日本語 (JIS 1 バイト カタカナ可)                |
| 50222    | iso-2022-jp             | 日本語 (JIS 1 バイト カタカナ可 - SO/SI)        |
| 50225    | iso-2022-kr             | 韓国語 (ISO)                            |
| 50227    | x-cp50227               | 簡体字中国語 (ISO-2022)                    |
| 51932    | euc-jp                  | 日本語 (EUC)                            |
| 51936    | EUC-CN                  | 簡体字中国語 (EUC)                         |
| 51949    | euc-kr                  | 韓国語 (EUC)                            |
| 52936    | hz-gb-2312              | 簡体字中国語 (HZ)                          |
| 54936    | GB18030                 | 簡体字中国語 (GB18030)                     |
| 57002    | x-iscii-de              | ISCII デバナガリ文字                        |
| 57003    | x-iscii-be              | ISCII ベンガル語                          |
| 57004    | x-iscii-ta              | ISCII タミール語                          |
| 57005    | x-iscii-te              | ISCII テルグ語                           |
| 57006    | x-iscii-as              | ISCII アッサム語                          |
| 57007    | x-iscii-or              | ISCII オリヤー語                          |
| 57008    | x-iscii-ka              | ISCII カナラ語                           |
| 57009    | x-iscii-ma              | ISCII マラヤラム語                         |
| 57010    | x-iscii-gu              | ISCII グジャラート語                        |
| 57011    | x-iscii-pa              | ISCII パンジャブ語                         |
| 65000    | utf-7                   | Unicode (UTF-7)                      |
| 65001    | utf-8                   | Unicode (UTF-8)                      |