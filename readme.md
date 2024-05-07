# LTimer

ライトニングトーク（以下、LTと省略）時に、ついつい時間を忘れて熱弁しまいませんか？
どんなに練習をしても、本番でテンションが上がってしまうと、いくら早口でしゃべっても、次から次へと言葉が沸いてしまう。

そんな貴方に送るLTimerです。

資料の好きな所にタイマー表示が出来るため、登壇しなら残り時間がわかります。


# Requirement

.NET7.0があれば問題なく動くハズです。

# Installation

.NETはこちらからダウンロードできます。
https://dotnet.microsoft.com/ja-jp/download/dotnet

# Usage

①実行するためには、SETTING.XMLが実行ファイルと同じフォルダに必要です。
SETTING.XMLは以下の書式になります。

```SETTING.XML
<SETTINGS>
    <START_X>2000</START_X>
    <START_Y>5</START_Y>
    <LTTIME>5</LTTIME>
    <RM30_MESSAGE>ラストスパート、Go！</RM30_MESSAGE>
    <RM30_COLOR>yellow</RM30_COLOR>
    <FIN_MESSAGE>💀💀💀💀💀💀💀💀</FIN_MESSAGE>
    <FIN_COLOR>red</FIN_COLOR>
</SETTINGS>
```

START_X,START_Y : 画面の表示位置です。

LTTIME : LT時間を分単位で指定します。小数点は無効になります。

RM30_MESSAGE / RM30_COLOR : LT時間が、残り30%～20%になると表示されるメッセージです。

FIN_MESSAGE / FIN_COLOR : LT時間が過ぎてしまった場合に表示されるメッセージです。

※色は、YELLOWやRED等で指定してください。

②実行すると、指定した箇所にLT時間が表示されます。

右クリックをするとメニューがでます。

メニューから、SETTING.XMLを開くことができます。変更後は、RESTARTを選択すると、変更が有効になります。

左クリックをすると、表示がプログレスバーになりカウントダウンがスタートとなります。

# Note

開発には、下記ツールを利用させて頂きました。

Visual Studio Community 2022 ver 17.9.3

※Microsoftさん、ありがとー！！

https://note.com/kerdy/n/ndfb08ef01edd

👆使い方などの他、コンパイルめんどいって方向けに、実行形式のファイル一式の提供も、こちらから実施しております。
ウィルスなどは仕込んでおりませんが、実行は自己責任でお願い致します。

# Author

* かーでぃ / かーでぃらぼ
* @_044722290292(X)

# License

"LTimer" is under [MIT license](https://en.wikipedia.org/wiki/MIT_License).

