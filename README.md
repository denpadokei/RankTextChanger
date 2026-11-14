# RankTextChanger

[![Build and Release](https://github.com/denpadokei/RankTextChanger/actions/workflows/build-and-release.yml/badge.svg)](https://github.com/denpadokei/RankTextChanger/actions/workflows/build-and-release.yml)

リザルト画面などに表示されるランク名 (SSS / SS / S …) を日本語の文字に置き換える MOD です。

## 機能

- `RankModel.GetRankName` を Harmony の Postfix でフックする
- E を `超悪`、D を `悪`、C を `微悪`、B を `普通` に置き換える
- A を `可`、S を `良`、SS を `超良`、SSS を `神` に置き換える
- 対応するランク以外はゲーム本来の文字列をそのまま使う
- ゲーム内の設定画面や設定ファイルは持たない
- プラグイン無効化時に Harmony パッチを解除する

## 動作環境

| 項目 | 内容 |
| --- | --- |
| Beat Saber | 1.21.0 |
| 依存 MOD | BSIPA 4.2.0 以降 |

## インストール

1. Beat Saber を 1.21.0 に合わせる (BSManager などのバージョン管理ツールを推奨)
2. BSIPA と上記の依存 MOD をインストールする
3. [Releases](https://github.com/denpadokei/RankTextChanger/releases) から `RankTextChanger-0.0.1-bs1.21.0.zip` をダウンロードし、`Plugins` フォルダをゲームフォルダへ上書きコピーする

## ビルド

```powershell
git clone https://github.com/denpadokei/RankTextChanger.git
cd RankTextChanger
dotnet build .\RankTextChanger\RankTextChanger.csproj -c Release
```

`BeatSaberDir` (または `GameDirectory`) に Beat Saber のインストール先を設定すると、ゲームの参照アセンブリを解決できます。

GitHub Actions の `build-and-release.yml` が push ごとにビルドし、`X.X.X` 形式のタグを push するとリリースを作成します。

## ライセンス

MIT License (`LICENSE`)
