using Autodesk.AutoCAD.DatabaseServices;

namespace AJS_DimensionSettings
{
    public enum TBType
    { Block, TextStyle, DimStyle, Layer, LineType, MLineStyle };

    internal static class DatabaseExts
    {
        public static ObjectId Search(this Database db, string entryname, TBType tp)
        {
            ObjectId id = ObjectId.Null;
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                if (tp == TBType.Block)
                {
                    BlockTable bt = tr.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    if (bt.Has(entryname)) id = bt[entryname];
                }
                else if (tp == TBType.TextStyle)
                {
                    TextStyleTable tbt = tr.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                    if (tbt.Has(entryname)) id = tbt[entryname];
                }
                else if (tp == TBType.DimStyle)
                {
                    DimStyleTable dst = tr.GetObject(db.DimStyleTableId, OpenMode.ForRead) as DimStyleTable;
                    if (dst.Has(entryname))
                        id = dst[entryname];
                    else
                        id = db.Dimstyle;
                }
                else if (tp == TBType.Layer)
                {
                    LayerTable lt = tr.GetObject(db.LayerTableId, OpenMode.ForRead) as LayerTable;
                    if (lt.Has(entryname)) id = lt[entryname];
                }
                else if (tp == TBType.LineType)
                {
                    LinetypeTable lt = tr.GetObject(db.LinetypeTableId, OpenMode.ForRead) as LinetypeTable;
                    if (lt.Has(entryname))
                        id = lt[entryname];
                    else
                    {
                        try
                        {
                            db.LoadLineTypeFile(entryname, "acad.lin");

                            if (lt.Has(entryname))
                            {
                                id = lt[entryname];
                            }
                        }
                        catch { }
                    }
                }
                else if (tp == TBType.MLineStyle)
                {
                    DBDictionary mlineDic = (DBDictionary)tr.GetObject(db.MLStyleDictionaryId, OpenMode.ForRead);
                    if (mlineDic.Contains(entryname))
                    {
                        id = mlineDic.GetAt(entryname);
                    }
                }
                tr.Commit();
            }
            return id;
        }
    }
}