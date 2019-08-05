### Xamarin勉強会
(Git使い方編)

---
### 目次

* 1.Gitとは、なじゃらほい?
* 2.環境作り
* 3.GitでPullしてみよう。
* 4.GitでCommitしてみよう。
* 5.GitでPushをしてみよう。
---

### 1.Gitとは、なじゃらほい?
* バージョン管理システムと呼ばれるものです。
* 下記のようなイメージをしていただけるとわかりやすいかと思います。
<img src="/image/image0.png" title="img 0" width="80%" height="80%">

---

### 2.環境作り

* まずWindows,Macで環境構築が違います。
* Macは、デフォで入っているため、何もする必要がありません。
* Windowsは、Git for Windowsのインストールをお願い致します。下記URLからインストール
* https://gitforwindows.org
* これで準備完了です。 (SorceTreeを使うとGitをGUI的に見えるので、そちらの方がいいかも)

---
### 3.GitでPullしてみよう。

* 下記にアクセスしていただくと画像のような画面の赤枠部分のURLをコピーしてください。
* https://github.com/OSTKatoKCoding/MobileWorkingGroup
* ターミナルを開き、環境を作りたいディレクトリで"git clone コピーしたURL"を入力し、実行。
<img src="/image/image1.png" title="img 1"  width="80%" height="80%">

---
### 4.GitでCommitしてみよう。

* ファイルの変更した際、変更を反映させたいと思います。
* コミットでまず、Gitに登録してあげましょう。
* "git add コミットしたいファイル"でファイルの選択を行います。
* git statusで確認
* git commit -m "コメント"でコミットされます。
* コメントは、残すようにした方が良いです。


