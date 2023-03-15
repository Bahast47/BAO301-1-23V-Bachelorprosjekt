// *******************************************
//          W A F - AUTO GENERATED CODE       
// Do not edit! File is regularly overwritten.
// *******************************************

using WAF.Data.Query;
using WAF.Engine.Query;
using WAF.Engine.Query.Advanced;

namespace WAF.Data.Query.MySite {

    public abstract class SqlRelCoursesIntructors {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_courses_intructors", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.MySite {

    public abstract class SqlRelCoursesParticipants {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_courses_participants", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.MySite {

    public abstract class SqlRelCoursesCategories {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_courses_categories", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Data.Query.MySite {

    public abstract class SqlRelCoursesVenues {

        public static SqlTable Table {
            get {
                return new SqlTable("rel_rel_courses_venues", TableId.RelationAbstract);
            }
        }

        public abstract class Field {

            public static SqlFieldInteger ParentId {
                get {
                    return new SqlFieldPrimaryInteger("parent_id", Table);
                }
            }

            public static SqlFieldInteger ChildId {
                get {
                    return new SqlFieldPrimaryInteger("child_id", Table);
                }
            }

            public static SqlFieldInteger Listorder {
                get {
                    return new SqlFieldInteger("listorder", Table);
                }
            }

        }
    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public abstract class AqlRelCoursesIntructors{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("183be1f6-01c2-4789-8220-b0a47f0c4a32") );
            }
        }

    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public abstract class AqlRelCoursesParticipants{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("c01ab5bb-6ba8-4da2-a106-e52e4ce721c5") );
            }
        }

    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public abstract class AqlRelCoursesCategories{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("d0666ab0-c52e-4171-96b6-fcd818f3b4ad") );
            }
        }

    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public abstract class AqlRelCoursesVenues{
        public static AqlClassRelation Relation {
            get {
                return new AqlClassRelation( WAFID.GetRelationId("572379c0-d187-46f8-851d-a874c7059c47") );
            }
        }

    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public class AqlAliasRelCoursesIntructors: AqlAliasRelation {

        public AqlAliasRelCoursesIntructors(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelCoursesIntructors.Relation) {

        }
        public AqlAliasRelCoursesIntructors(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelCoursesIntructors.Relation, onParent ) {

        }
        public AqlAliasRelCoursesIntructors(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelCoursesIntructors.Relation, onChild ) {

        }
        public AqlAliasRelCoursesIntructors(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelCoursesIntructors.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public class AqlAliasRelCoursesParticipants: AqlAliasRelation {

        public AqlAliasRelCoursesParticipants(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelCoursesParticipants.Relation) {

        }
        public AqlAliasRelCoursesParticipants(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelCoursesParticipants.Relation, onParent ) {

        }
        public AqlAliasRelCoursesParticipants(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelCoursesParticipants.Relation, onChild ) {

        }
        public AqlAliasRelCoursesParticipants(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelCoursesParticipants.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public class AqlAliasRelCoursesCategories: AqlAliasRelation {

        public AqlAliasRelCoursesCategories(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelCoursesCategories.Relation) {

        }
        public AqlAliasRelCoursesCategories(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelCoursesCategories.Relation, onParent ) {

        }
        public AqlAliasRelCoursesCategories(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelCoursesCategories.Relation, onChild ) {

        }
        public AqlAliasRelCoursesCategories(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelCoursesCategories.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Query.MySite{

    [System.Serializable]
    public class AqlAliasRelCoursesVenues: AqlAliasRelation {

        public AqlAliasRelCoursesVenues(AqlAlias parent, AqlAlias child)
             : base(parent, child, AqlRelCoursesVenues.Relation) {

        }
        public AqlAliasRelCoursesVenues(AqlAliasRelation parent, AqlAlias child, AqlAlias onParent)
             : base(parent, child, AqlRelCoursesVenues.Relation, onParent ) {

        }
        public AqlAliasRelCoursesVenues(AqlAlias parent, AqlAliasRelation child, AqlAlias onChild)
             : base(parent, child, AqlRelCoursesVenues.Relation, onChild ) {

        }
        public AqlAliasRelCoursesVenues(AqlAliasRelation parent, AqlAliasRelation child,AqlAlias onParent, AqlAlias onChild)
             : base(parent, child, AqlRelCoursesVenues.Relation, onParent, onChild ) {

        }
    }
}
namespace WAF.Engine.Content.MySite{
    [System.Serializable]
    public partial class RelCoursesIntructors: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("183be1f6-01c2-4789-8220-b0a47f0c4a32");
            }
        }

    }
}
namespace WAF.Engine.Content.MySite{
    [System.Serializable]
    public partial class RelCoursesParticipants: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("c01ab5bb-6ba8-4da2-a106-e52e4ce721c5");
            }
        }

    }
}
namespace WAF.Engine.Content.MySite{
    [System.Serializable]
    public partial class RelCoursesCategories: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("d0666ab0-c52e-4171-96b6-fcd818f3b4ad");
            }
        }

    }
}
namespace WAF.Engine.Content.MySite{
    [System.Serializable]
    public partial class RelCoursesVenues: WAF.Engine.Content.RelationBase {

        public static int RelationId {
            get {
                return WAFID.GetRelationId("572379c0-d187-46f8-851d-a874c7059c47");
            }
        }

    }
}
