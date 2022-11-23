// 完全なコードでないため拡張子を.txtにしている

public class Post
{
    public int PostId { get; set; }
    // ...
    // 外部キー
    public int UserFKey { get; set; }
    // ForeignKey属性で外部キープロパティ名を指定する
    [ForeignKey(nameof(UserFKey))]
    public User User { get; set; }
}