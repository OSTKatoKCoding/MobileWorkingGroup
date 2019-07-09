### Xamarin勉強会
(環境構築編)

---
### 目次

* 1.インストールをしてみよう!!
* 2.プロジェクトを新規で作ってみよう!!
* 3.Hello Worldの表示
* 4.シミュレータを立ち上げてみよう
---

### 1.インストールをしてみよう!!
* まずWindows,iOSどちらでも、基本visual studioをインストールしましょう。
* 下記からインストールしてください。
* https://visualstudio.microsoft.com/ja/free-developer-offers/

---
### 2.プロジェクトを新規で作ってみよう!!

* インストールは、できたでしょうか?
* それでは、立ち上げてみましょう!!
* 下記アイコンをクリックで立ち上がってきます。
* (下記はMacのアイコンですが、Windowsも同じかと思います。)
<img src="/image/img0.png" title="img0">

+++
### 2.プロジェクトを新規で作ってみよう!!

* 下記のような画面が立ち上がってきたかと思います。
* マルチプラットホームの「アプリ」を押下してください。
<img src="/image/img1.png" title="img1" width="50%" height="50%">

+++
### 2.プロジェクトを新規で作ってみよう!!
* 下記「空白ホームのアプリ」を選択してください。
<img src="/image/img2.png" title="img2" width="50%" height="50%">


+++
### 2.プロジェクトを新規で作ってみよう!!
* 下記のような画面が立ち上がってきたでしょうか?
* 必須項目を入力して「次へ」行きます。 ※説明は次のスライド
<img src="/image/img3.png" title="img3" width="50%" height="50%">


+++
### 2.プロジェクトを新規で作ってみよう!!
説明いたします。
* アプリ名：アプリ名 そのまんま!!
* 組織の識別子：各ストア(App Store や Google Play Store) で ID として必要なもの。
今回は、適当!!
* ターゲットプラットフォーム：そのまま、ターゲットは何かを選択
* 共有コード：Xamarinでは、コード共有化をすることができるらしい、その形式指定

+++
### 2.プロジェクトを新規で作ってみよう!!
<img src="/image/img4.png" title="img4" width="50%" height="50%">


+++
### 2.プロジェクトを新規で作ってみよう!!
* 下記のような画面が立ち上がってきたでしょうか?
* 今回は、何も考えず、「作成」押下で
<img src="/image/img5.png" title="img5" width="50%" height="50%">


+++
### 2.プロジェクトを新規で作ってみよう!!
* おめでとうございます!!コーディングの準備が整いました。
<img src="/image/img6.png" title="img6" width="50%" height="50%">


---
### 3.Hello Worldの表示
* さぁ、あいさつをしてみましょう!!
* 「MainPage.xmal」を開いてみましょう。
<img src="/image/img7.png" title="img7" width="50%" height="50%">


+++
### 3.Hello Worldの表示
下記コードがありますでしょうか？変更してみましょう!!
```xml
<Label Text="Welcome to Xamarin.Forms!" 
       HorizontalOptions="Center" 
       VerticalOptions="CenterAndExpand" />
↓
<Label Text="Hello World" 
       HorizontalOptions="Center"
       VerticalOptions="CenterAndExpand" />
```

---
### 4.シミュレータを立ち上げてみよう
準備が整いました。実行致しましょう!!
* 三角ボタンを押下してみましょう!! シュミレータが立ち上げれば成功です。
<img src="/image/img8.png" title="img8" width="50%" height="50%">
