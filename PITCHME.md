# Xamarin勉強会
(環境構築編)

---
## 目次

* 1.インストールをしてみよう!!
* 2.プロジェクトを新規で作ってみよう!!
* 3.Hello Worldの表示
* 4.シミュレータを立ち上げてみよう
* 5.まとめ
---

## 1.インストールをしてみよう!!
* まずWindows,iOSどちらでも、基本visual studioをインストールしましょう。
* 下記からインストールしてください。
* https://visualstudio.microsoft.com/ja/free-developer-offers/

---
## 2.プロジェクトを新規で作ってみよう!!

* インストールは、できたでしょうか?
* それでは、立ち上げてみましょう!!
* 下記アイコンをクリックで立ち上がってきます。
* (下記はMacのアイコンですが、Windowsも同じかと思います。)
![img0](image/img0.png)

+++
## 2.プロジェクトを新規で作ってみよう!!

* 下記のような画面が立ち上がってきたかと思います。
![img1](image/img1.png)
* マルチプラットホームの「アプリ」を押下してください。

+++
## 2.プロジェクトを新規で作ってみよう!!
* 下記「空白ホームのアプリ」を選択してください。
![img2](image/img2.png)

+++
## 2.プロジェクトを新規で作ってみよう!!
* 下記のような画面が立ち上がってきたでしょうか?
* 必須項目を入力して「次へ」行きます。 ※説明は次のスライド
![img3](image/img3.png)

+++
## 2.プロジェクトを新規で作ってみよう!!
説明いたします。
* アプリ名：アプリ名 そのまんま!!
* 組織の識別子：各ストア(App Store や Google Play Store) で ID として必要なもの。
今回は、適当!!
* ターゲットプラットフォーム：そのまま、ターゲットは何かを選択
* 共有コード：Xamarinでは、コード共有化をすることができるらしい、その形式指定

+++
## 2.プロジェクトを新規で作ってみよう!!
![img4](image/img4.png)

+++
## 2.プロジェクトを新規で作ってみよう!!
* 下記のような画面が立ち上がってきたでしょうか?
* 今回は、何も考えず、「作成」押下で
![img5](image/img5.png)

+++
## 2.プロジェクトを新規で作ってみよう!!
* おめでとうございます!!コーディングの準備が整いました。
![img6](image/img6.png)

---
## 3.Hello Worldの表示
* さぁ、あいさつをしてみましょう!!
* 「MainPage.xmal」を開いてみましょう。
![img7](image/img7.png)

+++
## 3.Hello Worldの表示
下記コードがありますでしょうか？変更してみましょう!!
```xml
<Label Text="Welcome to Xamarin.Forms!" HorizontalOptions="Center" VerticalOptions="CenterAndExpand" />
```
↓
```xml
<Label Text="Hello World" HorizontalOptions="Center" VerticalOptions="CenterAndExpand" />
```