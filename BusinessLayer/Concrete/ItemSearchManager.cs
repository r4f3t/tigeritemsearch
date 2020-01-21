using ItemSearchTiger.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemSearchTiger.BusinessLayer
{
    public class ItemSearchManager : IItemSearchService
    {
        TIGEREntities db = new TIGEREntities();
        TIGERSTREntities dbStr = new TIGERSTREntities();
        public ICollection<string> GetItems(string searchKey)
        {


            var query = db.LG_206_ITEMS.Include("lG_XT1001_206s").AsQueryable();

            query = query.Where(x =>
                (x.CODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.NAME).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.STGRPCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.PRODUCERCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.CYPHCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.UNIVID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.ISONR).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.GROUPNR).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.PRODCOUNTRY).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.LOGOID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.GTIPCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.EXPCTGNO).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.B2CCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTPLACE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE1).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE5).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE6).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE7).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE8).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE9).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE10).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.STATECODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.STATENAME).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.EXPCATEGORY).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.EANBARCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEPRCLASSTYPE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.ORGLOGOID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE5).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.ORIGIN).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.NAME2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.NAME3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.GLOBALID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.CATEGORYID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.CATEGORYNAME).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD1).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD5).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD1).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD5).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEDUCTCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.NAME4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.CPACODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FAUSEFULLIFECODE2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FAUSEFULLIFECODE).ToLower().Replace(" ", "").Contains(searchKey) 
                );

            var xtQuery = db.LG_XT1001_206.AsQueryable();
            xtQuery = xtQuery.Where(x=>
            (x.B2BACK1).ToLower().Replace(" ", "").Contains(searchKey) ||
            (x.B2BACK2).ToLower().Replace(" ", "").Contains(searchKey) ||
            (x.B2BACK3).ToLower().Replace(" ", "").Contains(searchKey) ||
            (x.B2BACK4).ToLower().Replace(" ", "").Contains(searchKey) ||
            (x.B2BACK5).ToLower().Replace(" ", "").Contains(searchKey)
            );

            var retList = query.Select(x => x.CODE).ToList();

            var queryRef = db.LG_206_ITEMS.AsQueryable();

            xtQuery.Select(x => x.PARLOGREF).ToList().ForEach(r =>
            {
                retList.AddRange(queryRef.Where(x => x.LOGICALREF == r).Select(x=>x.CODE).ToList());
               
            });
            retList.Sort();
            return retList;
        }

        public ICollection<string> GetItemsTigerStr(string searchKey)
        {
            var query = dbStr.LG_504_ITEMS.Include("lG_XT1001_206s").AsQueryable();

            query = query.Where(x =>
                (x.CODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.NAME).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.STGRPCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.PRODUCERCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.CYPHCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.UNIVID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.ISONR).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.GROUPNR).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.PRODCOUNTRY).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.LOGOID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.GTIPCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.EXPCTGNO).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.B2CCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTPLACE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE1).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE5).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE6).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE7).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE8).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE9).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FREIGHTTYPCODE10).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.STATECODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.STATENAME).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.EXPCATEGORY).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.EANBARCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEPRCLASSTYPE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.ORGLOGOID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.SPECODE5).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.ORIGIN).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.NAME2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.NAME3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.GLOBALID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.CATEGORYID).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.CATEGORYNAME).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD1).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.KEYWORD5).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD1).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD3).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEMANDMEETSORTFLD5).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.DEDUCTCODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.NAME4).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.CPACODE).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FAUSEFULLIFECODE2).ToLower().Replace(" ", "").Contains(searchKey) ||
                (x.FAUSEFULLIFECODE).ToLower().Replace(" ", "").Contains(searchKey)
                );

            var xtQuery = dbStr.LG_XT1001_504.AsQueryable();
            xtQuery = xtQuery.Where(x =>
            (x.B2BACK1).ToLower().Replace(" ", "").Contains(searchKey) ||
            (x.B2BACK2).ToLower().Replace(" ", "").Contains(searchKey) ||
            (x.B2BACK3).ToLower().Replace(" ", "").Contains(searchKey) ||
            (x.B2BACK4).ToLower().Replace(" ", "").Contains(searchKey) ||
            (x.B2BACK5).ToLower().Replace(" ", "").Contains(searchKey)
            );

            var retList = query.Select(x => x.CODE).ToList();

            var queryRef = dbStr.LG_504_ITEMS.AsQueryable();

            xtQuery.Select(x => x.PARLOGREF).ToList().ForEach(r =>
            {
                retList.AddRange(queryRef.Where(x => x.LOGICALREF == r).Select(x => x.CODE).ToList());

            });
            retList.Sort();
            return retList;
        }
    }
}
