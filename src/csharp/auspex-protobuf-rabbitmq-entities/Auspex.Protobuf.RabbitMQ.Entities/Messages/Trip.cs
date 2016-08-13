// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: trip.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Auspex.Protobuf.RabbitMQ.Entities.Messages {

  /// <summary>Holder for reflection information generated from trip.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class TripReflection {

    #region Descriptor
    /// <summary>File descriptor for trip.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TripReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgp0cmlwLnByb3RvEiphdXNwZXgucHJvdG9idWYucmFiYml0bXEuZW50aXRp",
            "ZXMubWVzc2FnZXMiIgoDQ2FyEgwKBG1ha2UYASABKAkSDQoFbW9kZWwYAiAB",
            "KAkiSQoITG9jYXRpb24SCgoCaWQYASABKAUSDAoEbmFtZRgCIAEoCRIQCghs",
            "YXRpdHVkZRgDIAEoARIRCglsb25naXR1ZGUYBCABKAEihAMKBFRyaXASCgoC",
            "aWQYASABKAUSSwoNc3RhcnRMb2NhdGlvbhgCIAEoCzI0LmF1c3BleC5wcm90",
            "b2J1Zi5yYWJiaXRtcS5lbnRpdGllcy5tZXNzYWdlcy5Mb2NhdGlvbhIRCglz",
            "dGFydFRpbWUYAyABKAMSSQoLZW5kTG9jYXRpb24YBCABKAsyNC5hdXNwZXgu",
            "cHJvdG9idWYucmFiYml0bXEuZW50aXRpZXMubWVzc2FnZXMuTG9jYXRpb24S",
            "DwoHZW5kVGltZRgFIAEoAxI8CgNjYXIYBiABKAsyLy5hdXNwZXgucHJvdG9i",
            "dWYucmFiYml0bXEuZW50aXRpZXMubWVzc2FnZXMuQ2FyEkcKBHR5cGUYByAB",
            "KA4yOS5hdXNwZXgucHJvdG9idWYucmFiYml0bXEuZW50aXRpZXMubWVzc2Fn",
            "ZXMuVHJpcC5UcmlwVHlwZSItCghUcmlwVHlwZRIICgRXT1JLEAASCgoGVFJB",
            "VkVMEAESCwoHUFJJVkFURRACIlMKEFRyaXBSZWdpc3RyYXRpb24SPwoFdHJp",
            "cHMYASADKAsyMC5hdXNwZXgucHJvdG9idWYucmFiYml0bXEuZW50aXRpZXMu",
            "bWVzc2FnZXMuVHJpcEItqgIqQXVzcGV4LlByb3RvYnVmLlJhYmJpdE1RLkVu",
            "dGl0aWVzLk1lc3NhZ2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Car), global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Car.Parser, new[]{ "Make", "Model" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location), global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location.Parser, new[]{ "Id", "Name", "Latitude", "Longitude" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip), global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip.Parser, new[]{ "Id", "StartLocation", "StartTime", "EndLocation", "EndTime", "Car", "Type" }, null, new[]{ typeof(global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip.Types.TripType) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Auspex.Protobuf.RabbitMQ.Entities.Messages.TripRegistration), global::Auspex.Protobuf.RabbitMQ.Entities.Messages.TripRegistration.Parser, new[]{ "Trips" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Car : pb::IMessage<Car> {
    private static readonly pb::MessageParser<Car> _parser = new pb::MessageParser<Car>(() => new Car());
    public static pb::MessageParser<Car> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Auspex.Protobuf.RabbitMQ.Entities.Messages.TripReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Car() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Car(Car other) : this() {
      make_ = other.make_;
      model_ = other.model_;
    }

    public Car Clone() {
      return new Car(this);
    }

    /// <summary>Field number for the "make" field.</summary>
    public const int MakeFieldNumber = 1;
    private string make_ = "";
    public string Make {
      get { return make_; }
      set {
        make_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "model" field.</summary>
    public const int ModelFieldNumber = 2;
    private string model_ = "";
    public string Model {
      get { return model_; }
      set {
        model_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Car);
    }

    public bool Equals(Car other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Make != other.Make) return false;
      if (Model != other.Model) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Make.Length != 0) hash ^= Make.GetHashCode();
      if (Model.Length != 0) hash ^= Model.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Make.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Make);
      }
      if (Model.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Model);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Make.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Make);
      }
      if (Model.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Model);
      }
      return size;
    }

    public void MergeFrom(Car other) {
      if (other == null) {
        return;
      }
      if (other.Make.Length != 0) {
        Make = other.Make;
      }
      if (other.Model.Length != 0) {
        Model = other.Model;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Make = input.ReadString();
            break;
          }
          case 18: {
            Model = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Location : pb::IMessage<Location> {
    private static readonly pb::MessageParser<Location> _parser = new pb::MessageParser<Location>(() => new Location());
    public static pb::MessageParser<Location> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Auspex.Protobuf.RabbitMQ.Entities.Messages.TripReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Location() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Location(Location other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
    }

    public Location Clone() {
      return new Location(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 3;
    private double latitude_;
    public double Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 4;
    private double longitude_;
    public double Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Location);
    }

    public bool Equals(Location other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Latitude != 0D) hash ^= Latitude.GetHashCode();
      if (Longitude != 0D) hash ^= Longitude.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Latitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Latitude);
      }
      if (Longitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Longitude);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Latitude != 0D) {
        size += 1 + 8;
      }
      if (Longitude != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(Location other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Latitude != 0D) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0D) {
        Longitude = other.Longitude;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 25: {
            Latitude = input.ReadDouble();
            break;
          }
          case 33: {
            Longitude = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Trip : pb::IMessage<Trip> {
    private static readonly pb::MessageParser<Trip> _parser = new pb::MessageParser<Trip>(() => new Trip());
    public static pb::MessageParser<Trip> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Auspex.Protobuf.RabbitMQ.Entities.Messages.TripReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Trip() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Trip(Trip other) : this() {
      id_ = other.id_;
      StartLocation = other.startLocation_ != null ? other.StartLocation.Clone() : null;
      startTime_ = other.startTime_;
      EndLocation = other.endLocation_ != null ? other.EndLocation.Clone() : null;
      endTime_ = other.endTime_;
      Car = other.car_ != null ? other.Car.Clone() : null;
      type_ = other.type_;
    }

    public Trip Clone() {
      return new Trip(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "startLocation" field.</summary>
    public const int StartLocationFieldNumber = 2;
    private global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location startLocation_;
    public global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location StartLocation {
      get { return startLocation_; }
      set {
        startLocation_ = value;
      }
    }

    /// <summary>Field number for the "startTime" field.</summary>
    public const int StartTimeFieldNumber = 3;
    private long startTime_;
    public long StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "endLocation" field.</summary>
    public const int EndLocationFieldNumber = 4;
    private global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location endLocation_;
    public global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location EndLocation {
      get { return endLocation_; }
      set {
        endLocation_ = value;
      }
    }

    /// <summary>Field number for the "endTime" field.</summary>
    public const int EndTimeFieldNumber = 5;
    private long endTime_;
    public long EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "car" field.</summary>
    public const int CarFieldNumber = 6;
    private global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Car car_;
    public global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Car Car {
      get { return car_; }
      set {
        car_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 7;
    private global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip.Types.TripType type_ = 0;
    public global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip.Types.TripType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Trip);
    }

    public bool Equals(Trip other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (!object.Equals(StartLocation, other.StartLocation)) return false;
      if (StartTime != other.StartTime) return false;
      if (!object.Equals(EndLocation, other.EndLocation)) return false;
      if (EndTime != other.EndTime) return false;
      if (!object.Equals(Car, other.Car)) return false;
      if (Type != other.Type) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (startLocation_ != null) hash ^= StartLocation.GetHashCode();
      if (StartTime != 0L) hash ^= StartTime.GetHashCode();
      if (endLocation_ != null) hash ^= EndLocation.GetHashCode();
      if (EndTime != 0L) hash ^= EndTime.GetHashCode();
      if (car_ != null) hash ^= Car.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (startLocation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartLocation);
      }
      if (StartTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(StartTime);
      }
      if (endLocation_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EndLocation);
      }
      if (EndTime != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(EndTime);
      }
      if (car_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Car);
      }
      if (Type != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Type);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (startLocation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartLocation);
      }
      if (StartTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StartTime);
      }
      if (endLocation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EndLocation);
      }
      if (EndTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EndTime);
      }
      if (car_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Car);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      return size;
    }

    public void MergeFrom(Trip other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.startLocation_ != null) {
        if (startLocation_ == null) {
          startLocation_ = new global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location();
        }
        StartLocation.MergeFrom(other.StartLocation);
      }
      if (other.StartTime != 0L) {
        StartTime = other.StartTime;
      }
      if (other.endLocation_ != null) {
        if (endLocation_ == null) {
          endLocation_ = new global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location();
        }
        EndLocation.MergeFrom(other.EndLocation);
      }
      if (other.EndTime != 0L) {
        EndTime = other.EndTime;
      }
      if (other.car_ != null) {
        if (car_ == null) {
          car_ = new global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Car();
        }
        Car.MergeFrom(other.Car);
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            if (startLocation_ == null) {
              startLocation_ = new global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location();
            }
            input.ReadMessage(startLocation_);
            break;
          }
          case 24: {
            StartTime = input.ReadInt64();
            break;
          }
          case 34: {
            if (endLocation_ == null) {
              endLocation_ = new global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Location();
            }
            input.ReadMessage(endLocation_);
            break;
          }
          case 40: {
            EndTime = input.ReadInt64();
            break;
          }
          case 50: {
            if (car_ == null) {
              car_ = new global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Car();
            }
            input.ReadMessage(car_);
            break;
          }
          case 56: {
            type_ = (global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip.Types.TripType) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Trip message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum TripType {
        [pbr::OriginalName("WORK")] Work = 0,
        [pbr::OriginalName("TRAVEL")] Travel = 1,
        [pbr::OriginalName("PRIVATE")] Private = 2,
      }

    }
    #endregion

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class TripRegistration : pb::IMessage<TripRegistration> {
    private static readonly pb::MessageParser<TripRegistration> _parser = new pb::MessageParser<TripRegistration>(() => new TripRegistration());
    public static pb::MessageParser<TripRegistration> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Auspex.Protobuf.RabbitMQ.Entities.Messages.TripReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public TripRegistration() {
      OnConstruction();
    }

    partial void OnConstruction();

    public TripRegistration(TripRegistration other) : this() {
      trips_ = other.trips_.Clone();
    }

    public TripRegistration Clone() {
      return new TripRegistration(this);
    }

    /// <summary>Field number for the "trips" field.</summary>
    public const int TripsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip> _repeated_trips_codec
        = pb::FieldCodec.ForMessage(10, global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip.Parser);
    private readonly pbc::RepeatedField<global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip> trips_ = new pbc::RepeatedField<global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip>();
    public pbc::RepeatedField<global::Auspex.Protobuf.RabbitMQ.Entities.Messages.Trip> Trips {
      get { return trips_; }
    }

    public override bool Equals(object other) {
      return Equals(other as TripRegistration);
    }

    public bool Equals(TripRegistration other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!trips_.Equals(other.trips_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= trips_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      trips_.WriteTo(output, _repeated_trips_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += trips_.CalculateSize(_repeated_trips_codec);
      return size;
    }

    public void MergeFrom(TripRegistration other) {
      if (other == null) {
        return;
      }
      trips_.Add(other.trips_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            trips_.AddEntriesFrom(input, _repeated_trips_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code