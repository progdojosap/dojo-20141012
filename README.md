dojo-20141012
=============

## 道場で用意した開発環境

- 素早いテストのフィードバックができる
- コード履歴を記録できる
- VisualStudio2013 Expressで動作する

---

## インストールの省力化

### Chocolatey

windows パッケージマネージャー
cmd.exe [管理者として実行]

    @powershell -NoProfile -ExecutionPolicy unrestricted -Command "iex ((new-object   net.webclient).DownloadString('https://chocolatey.org/install.ps1'))" && SET PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin

---

## 素早いテストのフィードバック

### NUnit

テストフレームワーク
NuGetでインストール

    Install-Package NUnit

### giles

ファイル保存時にテストランナー実行
NuGetでインストール

    Install-Package giles

#### gilesの実行方法

PowerShellを実行

ソリューションフォルダまで移動

下記を実行

    ./giles.ps1

### growl テスト結果通知

    choco install growl

---


### NUnit.Snippets

t - m - tab - tab で テストメソッド生成
a - t - i - e - tab - tab で Assert.That(actual, Is.EqualTo(expected)) を生成

NuGetでインストール

    Install-Package NUnit.Snippets

---

## コード履歴の記録

### SourceTree

GUIのgitリポジトリ管理

    choco install sourcetree.install

### git now

    git clone —recursive  https://github.com/iwata/git-now.git

—recursive でサブプロジェクトも一気にcloneする.
gitnow-shFlags を サブプロジェクトの shFlags で置き換えること.

#### getopt

git now で利用している getopt.exe は SourceTreeの msysgit には同梱されていない.
仕方ないので、getoptのwindows版バイナリを手に入れ, /bin/git のいるフォルダに直接放りこんでやる。
まず util-linux-ng for Windows から Binaries の Zip と Dependencies の Zip をダウンロードして解凍。
Binaries/bin から getopt.exe を、Dependencies/bin から libintl3.dll を取り出して、Gitのインストールディレクトリ/bin に入れる。 
