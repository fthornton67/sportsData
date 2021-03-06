﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5466
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://feed.elasticstats.com/schema/nfl/depth_chart-v1.0.xsd")]
[System.Xml.Serialization.XmlRootAttribute("game", Namespace="http://feed.elasticstats.com/schema/nfl/depth_chart-v1.0.xsd", IsNullable=false)]
public partial class gameType {
    
    private teamType[] teamField;
    
    private string awayField;
    
    private string homeField;
    
    private string idField;
    
    private System.DateTime scheduledField;
    
    private gameTypeStatus statusField;
    
    private bool statusFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("team")]
    public teamType[] team {
        get {
            return this.teamField;
        }
        set {
            this.teamField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string away {
        get {
            return this.awayField;
        }
        set {
            this.awayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string home {
        get {
            return this.homeField;
        }
        set {
            this.homeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime scheduled {
        get {
            return this.scheduledField;
        }
        set {
            this.scheduledField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public gameTypeStatus status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool statusSpecified {
        get {
            return this.statusFieldSpecified;
        }
        set {
            this.statusFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://feed.elasticstats.com/schema/nfl/depth_chart-v1.0.xsd")]
[System.Xml.Serialization.XmlRootAttribute("team", Namespace="http://feed.elasticstats.com/schema/nfl/depth_chart-v1.0.xsd", IsNullable=false)]
public partial class teamType {
    
    private squadType offenseField;
    
    private squadType defenseField;
    
    private squadType special_teamsField;
    
    private string idField;
    
    private string marketField;
    
    private string nameField;
    
    /// <remarks/>
    public squadType offense {
        get {
            return this.offenseField;
        }
        set {
            this.offenseField = value;
        }
    }
    
    /// <remarks/>
    public squadType defense {
        get {
            return this.defenseField;
        }
        set {
            this.defenseField = value;
        }
    }
    
    /// <remarks/>
    public squadType special_teams {
        get {
            return this.special_teamsField;
        }
        set {
            this.special_teamsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string market {
        get {
            return this.marketField;
        }
        set {
            this.marketField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://feed.elasticstats.com/schema/nfl/depth_chart-v1.0.xsd")]
public partial class squadType {
    
    private positionType[] positionField;
    
    private string typeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("position")]
    public positionType[] position {
        get {
            return this.positionField;
        }
        set {
            this.positionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://feed.elasticstats.com/schema/nfl/depth_chart-v1.0.xsd")]
public partial class positionType {
    
    private playerType[] playerField;
    
    private string descField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("player")]
    public playerType[] player {
        get {
            return this.playerField;
        }
        set {
            this.playerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://feed.elasticstats.com/schema/nfl/depth_chart-v1.0.xsd")]
public partial class playerType {
    
    private string depthField;
    
    private string idField;
    
    private string jersey_numberField;
    
    private string name_fullField;
    
    private string positionField;
    
    private string statusField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string depth {
        get {
            return this.depthField;
        }
        set {
            this.depthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string jersey_number {
        get {
            return this.jersey_numberField;
        }
        set {
            this.jersey_numberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name_full {
        get {
            return this.name_fullField;
        }
        set {
            this.name_fullField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string position {
        get {
            return this.positionField;
        }
        set {
            this.positionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://feed.elasticstats.com/schema/nfl/depth_chart-v1.0.xsd")]
public enum gameTypeStatus {
    
    /// <remarks/>
    scheduled,
    
    /// <remarks/>
    created,
    
    /// <remarks/>
    inprogress,
    
    /// <remarks/>
    complete,
    
    /// <remarks/>
    closed,
    
    /// <remarks/>
    reopened,
}
