GUIプログラミング入門 by Windows Forms
=====

## はじめに

本文書はGUI（グラフィック・ユーザー・インターフェース）を持ったアプリケーションを作成するために、どのようにプログラミングすればよいかを身に付けることを目的としています。対象プラットフォームはWindows Formsで、プログラミング言語にはC#を用います。
RDBMSの操作、ファイル操作、Webアクセス等の外部サービスとの連携方法については、本文書の対象外とします。

### 想定する読者
- C#を使って簡単なコンソールアプリケーションが作成できる程度に習熟している
- Visual Studioを用いたプロジェクト作成、実行手順など一通り習熟している

### 本文書のゴール
- 単一画面を持つアプリケーションが作成できる
- 複数画面間のデータ連携を行うアプリケーションが作成できる
- 例外や入力値の検証（バリデーション）等のエラー処理を適切に行える

### 本文書の開発環境
- Windows 10 Pro 64bit
- Visual Studio 2015 Community

## 目次

1. [Hello World!](doc/01-hello-world.md)  
	まずは画面を表示して文字を表示するプログラムを作成し、その仕組みを理解していきましょう。
2. [ボタンを押すと……？](doc/02-click-button.md)  
	ボタンを使ってイベント処理の基本を理解していきましょう。
3. [あなたのお名前は？](doc/03-whats-your-name.md)  
	テキストボックスコントロールを使って、アプリケーションに値を伝える方法を理解していきましょう。
4. [様々なコントロールたち](doc/04-various-controls.md)  
    アプリで使う主なコントロールの特徴を理解していきましょう。
5. [クリック！クリック！](doc/05-click-click.md)  
    ボタンを押したら数字がカウントアップするアプリケーションを通じて、「状態」を管理する方法を理解していきましょう。  
6. [それはできません](doc/06-cannot-do-it.md)  
    テキストボックスなどに入力された値の妥当性を判断し、結果をユーザーに伝える方法を理解していきましょう。  
7. [貴方にお任せ](doc/07-leave-it-to-you.md)    
    ダイアログ形式で画面を表示して、処理を交代する方法を理解していきましょう。
8. [一緒にやろう](doc/08-work-together.md)  
    2つの画面で連携して処理を行う方法を理解していきましょう。

## サンプルについて

各章のサンプルコードは、`src`フォルダーの下にある章番号フォルダーの中にあります。リポジトリ全体をzipファイル等でダウンロードして展開後、Visual Studioでソリューションを開いて内容を確認してください。

## 参考資料
- [Visual C# と Visual Basic の概要](https://msdn.microsoft.com/ja-jp/library/dd492171.aspx)
- [プレゼンテーションとドメインの分離](http://bliki-ja.github.io/PresentationDomainSeparation/)
- [Windows フォームでのデータ バインド](https://msdn.microsoft.com/ja-jp/library/ef2xyb33.aspx)
- [双方向データバインドによる単体入力エラーチェック – とあるコンサルタントのつぶやき](https://blogs.msdn.microsoft.com/nakama/2009/02/26/383/)
    - [Part 1. 双方向データバインドの基本的な使い方](https://blogs.msdn.microsoft.com/nakama/2009/02/26/part-1-2/)
    - [Part 2. スマートクライアントにおける単体入力データ検証](https://blogs.msdn.microsoft.com/nakama/2009/02/26/part-2-2/)
- [エラーチェックの体系的な分類と実装パターン – とあるコンサルタントのつぶやき](https://blogs.msdn.microsoft.com/nakama/2009/09/28/303/)
    - [Part 1. エラーチェックの体系的な分類方法](https://blogs.msdn.microsoft.com/nakama/2009/09/28/293/)
    - [Part 2. 単体入力エラーチェックの実装パターン](https://blogs.msdn.microsoft.com/nakama/2009/09/28/283/)
- .NETの例外処理 – とあるコンサルタントのつぶやき
    - [Part.1](https://blogs.msdn.microsoft.com/nakama/2008/12/29/net-part-1/)
    - [Part.2](https://blogs.msdn.microsoft.com/nakama/2009/01/02/net-part-2/)
    - [Part.3](https://blogs.msdn.microsoft.com/nakama/2009/01/18/net-part-3/)
    - [Part.4](https://blogs.msdn.microsoft.com/nakama/2009/01/23/net-part-4/)
