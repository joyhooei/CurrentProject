// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Protocol/Attribute.proto

package com.hawk.game.protocol;

public final class Attribute {
  private Attribute() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
  }
  public interface AttrOrBuilder
      extends com.google.protobuf.MessageOrBuilder {

    // required int32 attrId = 1;
    /**
     * <code>required int32 attrId = 1;</code>
     *
     * <pre>
     * 属性id(参考Const.attr)
     * </pre>
     */
    boolean hasAttrId();
    /**
     * <code>required int32 attrId = 1;</code>
     *
     * <pre>
     * 属性id(参考Const.attr)
     * </pre>
     */
    int getAttrId();

    // required float attrValue = 2;
    /**
     * <code>required float attrValue = 2;</code>
     *
     * <pre>
     * 属性值
     * </pre>
     */
    boolean hasAttrValue();
    /**
     * <code>required float attrValue = 2;</code>
     *
     * <pre>
     * 属性值
     * </pre>
     */
    float getAttrValue();
  }
  /**
   * Protobuf type {@code Attr}
   */
  public static final class Attr extends
      com.google.protobuf.GeneratedMessage
      implements AttrOrBuilder {
    // Use Attr.newBuilder() to construct.
    private Attr(com.google.protobuf.GeneratedMessage.Builder<?> builder) {
      super(builder);
      this.unknownFields = builder.getUnknownFields();
    }
    private Attr(boolean noInit) { this.unknownFields = com.google.protobuf.UnknownFieldSet.getDefaultInstance(); }

    private static final Attr defaultInstance;
    public static Attr getDefaultInstance() {
      return defaultInstance;
    }

    public Attr getDefaultInstanceForType() {
      return defaultInstance;
    }

    private final com.google.protobuf.UnknownFieldSet unknownFields;
    @java.lang.Override
    public final com.google.protobuf.UnknownFieldSet
        getUnknownFields() {
      return this.unknownFields;
    }
    private Attr(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      initFields();
      int mutable_bitField0_ = 0;
      com.google.protobuf.UnknownFieldSet.Builder unknownFields =
          com.google.protobuf.UnknownFieldSet.newBuilder();
      try {
        boolean done = false;
        while (!done) {
          int tag = input.readTag();
          switch (tag) {
            case 0:
              done = true;
              break;
            default: {
              if (!parseUnknownField(input, unknownFields,
                                     extensionRegistry, tag)) {
                done = true;
              }
              break;
            }
            case 8: {
              bitField0_ |= 0x00000001;
              attrId_ = input.readInt32();
              break;
            }
            case 21: {
              bitField0_ |= 0x00000002;
              attrValue_ = input.readFloat();
              break;
            }
          }
        }
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        throw e.setUnfinishedMessage(this);
      } catch (java.io.IOException e) {
        throw new com.google.protobuf.InvalidProtocolBufferException(
            e.getMessage()).setUnfinishedMessage(this);
      } finally {
        this.unknownFields = unknownFields.build();
        makeExtensionsImmutable();
      }
    }
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return com.hawk.game.protocol.Attribute.internal_static_Attr_descriptor;
    }

    protected com.google.protobuf.GeneratedMessage.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return com.hawk.game.protocol.Attribute.internal_static_Attr_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              com.hawk.game.protocol.Attribute.Attr.class, com.hawk.game.protocol.Attribute.Attr.Builder.class);
    }

    public static com.google.protobuf.Parser<Attr> PARSER =
        new com.google.protobuf.AbstractParser<Attr>() {
      public Attr parsePartialFrom(
          com.google.protobuf.CodedInputStream input,
          com.google.protobuf.ExtensionRegistryLite extensionRegistry)
          throws com.google.protobuf.InvalidProtocolBufferException {
        return new Attr(input, extensionRegistry);
      }
    };

    @java.lang.Override
    public com.google.protobuf.Parser<Attr> getParserForType() {
      return PARSER;
    }

    private int bitField0_;
    // required int32 attrId = 1;
    public static final int ATTRID_FIELD_NUMBER = 1;
    private int attrId_;
    /**
     * <code>required int32 attrId = 1;</code>
     *
     * <pre>
     * 属性id(参考Const.attr)
     * </pre>
     */
    public boolean hasAttrId() {
      return ((bitField0_ & 0x00000001) == 0x00000001);
    }
    /**
     * <code>required int32 attrId = 1;</code>
     *
     * <pre>
     * 属性id(参考Const.attr)
     * </pre>
     */
    public int getAttrId() {
      return attrId_;
    }

    // required float attrValue = 2;
    public static final int ATTRVALUE_FIELD_NUMBER = 2;
    private float attrValue_;
    /**
     * <code>required float attrValue = 2;</code>
     *
     * <pre>
     * 属性值
     * </pre>
     */
    public boolean hasAttrValue() {
      return ((bitField0_ & 0x00000002) == 0x00000002);
    }
    /**
     * <code>required float attrValue = 2;</code>
     *
     * <pre>
     * 属性值
     * </pre>
     */
    public float getAttrValue() {
      return attrValue_;
    }

    private void initFields() {
      attrId_ = 0;
      attrValue_ = 0F;
    }
    private byte memoizedIsInitialized = -1;
    public final boolean isInitialized() {
      byte isInitialized = memoizedIsInitialized;
      if (isInitialized != -1) return isInitialized == 1;

      if (!hasAttrId()) {
        memoizedIsInitialized = 0;
        return false;
      }
      if (!hasAttrValue()) {
        memoizedIsInitialized = 0;
        return false;
      }
      memoizedIsInitialized = 1;
      return true;
    }

    public void writeTo(com.google.protobuf.CodedOutputStream output)
                        throws java.io.IOException {
      getSerializedSize();
      if (((bitField0_ & 0x00000001) == 0x00000001)) {
        output.writeInt32(1, attrId_);
      }
      if (((bitField0_ & 0x00000002) == 0x00000002)) {
        output.writeFloat(2, attrValue_);
      }
      getUnknownFields().writeTo(output);
    }

    private int memoizedSerializedSize = -1;
    public int getSerializedSize() {
      int size = memoizedSerializedSize;
      if (size != -1) return size;

      size = 0;
      if (((bitField0_ & 0x00000001) == 0x00000001)) {
        size += com.google.protobuf.CodedOutputStream
          .computeInt32Size(1, attrId_);
      }
      if (((bitField0_ & 0x00000002) == 0x00000002)) {
        size += com.google.protobuf.CodedOutputStream
          .computeFloatSize(2, attrValue_);
      }
      size += getUnknownFields().getSerializedSize();
      memoizedSerializedSize = size;
      return size;
    }

    private static final long serialVersionUID = 0L;
    @java.lang.Override
    protected java.lang.Object writeReplace()
        throws java.io.ObjectStreamException {
      return super.writeReplace();
    }

    public static com.hawk.game.protocol.Attribute.Attr parseFrom(
        com.google.protobuf.ByteString data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseFrom(
        com.google.protobuf.ByteString data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data, extensionRegistry);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseFrom(byte[] data)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseFrom(
        byte[] data,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return PARSER.parseFrom(data, extensionRegistry);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseFrom(java.io.InputStream input)
        throws java.io.IOException {
      return PARSER.parseFrom(input);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseFrom(
        java.io.InputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return PARSER.parseFrom(input, extensionRegistry);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseDelimitedFrom(java.io.InputStream input)
        throws java.io.IOException {
      return PARSER.parseDelimitedFrom(input);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseDelimitedFrom(
        java.io.InputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return PARSER.parseDelimitedFrom(input, extensionRegistry);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseFrom(
        com.google.protobuf.CodedInputStream input)
        throws java.io.IOException {
      return PARSER.parseFrom(input);
    }
    public static com.hawk.game.protocol.Attribute.Attr parseFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      return PARSER.parseFrom(input, extensionRegistry);
    }

    public static Builder newBuilder() { return Builder.create(); }
    public Builder newBuilderForType() { return newBuilder(); }
    public static Builder newBuilder(com.hawk.game.protocol.Attribute.Attr prototype) {
      return newBuilder().mergeFrom(prototype);
    }
    public Builder toBuilder() { return newBuilder(this); }

    @java.lang.Override
    protected Builder newBuilderForType(
        com.google.protobuf.GeneratedMessage.BuilderParent parent) {
      Builder builder = new Builder(parent);
      return builder;
    }
    /**
     * Protobuf type {@code Attr}
     */
    public static final class Builder extends
        com.google.protobuf.GeneratedMessage.Builder<Builder>
       implements com.hawk.game.protocol.Attribute.AttrOrBuilder {
      public static final com.google.protobuf.Descriptors.Descriptor
          getDescriptor() {
        return com.hawk.game.protocol.Attribute.internal_static_Attr_descriptor;
      }

      protected com.google.protobuf.GeneratedMessage.FieldAccessorTable
          internalGetFieldAccessorTable() {
        return com.hawk.game.protocol.Attribute.internal_static_Attr_fieldAccessorTable
            .ensureFieldAccessorsInitialized(
                com.hawk.game.protocol.Attribute.Attr.class, com.hawk.game.protocol.Attribute.Attr.Builder.class);
      }

      // Construct using com.hawk.game.protocol.Attribute.Attr.newBuilder()
      private Builder() {
        maybeForceBuilderInitialization();
      }

      private Builder(
          com.google.protobuf.GeneratedMessage.BuilderParent parent) {
        super(parent);
        maybeForceBuilderInitialization();
      }
      private void maybeForceBuilderInitialization() {
        if (com.google.protobuf.GeneratedMessage.alwaysUseFieldBuilders) {
        }
      }
      private static Builder create() {
        return new Builder();
      }

      public Builder clear() {
        super.clear();
        attrId_ = 0;
        bitField0_ = (bitField0_ & ~0x00000001);
        attrValue_ = 0F;
        bitField0_ = (bitField0_ & ~0x00000002);
        return this;
      }

      public Builder clone() {
        return create().mergeFrom(buildPartial());
      }

      public com.google.protobuf.Descriptors.Descriptor
          getDescriptorForType() {
        return com.hawk.game.protocol.Attribute.internal_static_Attr_descriptor;
      }

      public com.hawk.game.protocol.Attribute.Attr getDefaultInstanceForType() {
        return com.hawk.game.protocol.Attribute.Attr.getDefaultInstance();
      }

      public com.hawk.game.protocol.Attribute.Attr build() {
        com.hawk.game.protocol.Attribute.Attr result = buildPartial();
        if (!result.isInitialized()) {
          throw newUninitializedMessageException(result);
        }
        return result;
      }

      public com.hawk.game.protocol.Attribute.Attr buildPartial() {
        com.hawk.game.protocol.Attribute.Attr result = new com.hawk.game.protocol.Attribute.Attr(this);
        int from_bitField0_ = bitField0_;
        int to_bitField0_ = 0;
        if (((from_bitField0_ & 0x00000001) == 0x00000001)) {
          to_bitField0_ |= 0x00000001;
        }
        result.attrId_ = attrId_;
        if (((from_bitField0_ & 0x00000002) == 0x00000002)) {
          to_bitField0_ |= 0x00000002;
        }
        result.attrValue_ = attrValue_;
        result.bitField0_ = to_bitField0_;
        onBuilt();
        return result;
      }

      public Builder mergeFrom(com.google.protobuf.Message other) {
        if (other instanceof com.hawk.game.protocol.Attribute.Attr) {
          return mergeFrom((com.hawk.game.protocol.Attribute.Attr)other);
        } else {
          super.mergeFrom(other);
          return this;
        }
      }

      public Builder mergeFrom(com.hawk.game.protocol.Attribute.Attr other) {
        if (other == com.hawk.game.protocol.Attribute.Attr.getDefaultInstance()) return this;
        if (other.hasAttrId()) {
          setAttrId(other.getAttrId());
        }
        if (other.hasAttrValue()) {
          setAttrValue(other.getAttrValue());
        }
        this.mergeUnknownFields(other.getUnknownFields());
        return this;
      }

      public final boolean isInitialized() {
        if (!hasAttrId()) {
          
          return false;
        }
        if (!hasAttrValue()) {
          
          return false;
        }
        return true;
      }

      public Builder mergeFrom(
          com.google.protobuf.CodedInputStream input,
          com.google.protobuf.ExtensionRegistryLite extensionRegistry)
          throws java.io.IOException {
        com.hawk.game.protocol.Attribute.Attr parsedMessage = null;
        try {
          parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
        } catch (com.google.protobuf.InvalidProtocolBufferException e) {
          parsedMessage = (com.hawk.game.protocol.Attribute.Attr) e.getUnfinishedMessage();
          throw e;
        } finally {
          if (parsedMessage != null) {
            mergeFrom(parsedMessage);
          }
        }
        return this;
      }
      private int bitField0_;

      // required int32 attrId = 1;
      private int attrId_ ;
      /**
       * <code>required int32 attrId = 1;</code>
       *
       * <pre>
       * 属性id(参考Const.attr)
       * </pre>
       */
      public boolean hasAttrId() {
        return ((bitField0_ & 0x00000001) == 0x00000001);
      }
      /**
       * <code>required int32 attrId = 1;</code>
       *
       * <pre>
       * 属性id(参考Const.attr)
       * </pre>
       */
      public int getAttrId() {
        return attrId_;
      }
      /**
       * <code>required int32 attrId = 1;</code>
       *
       * <pre>
       * 属性id(参考Const.attr)
       * </pre>
       */
      public Builder setAttrId(int value) {
        bitField0_ |= 0x00000001;
        attrId_ = value;
        onChanged();
        return this;
      }
      /**
       * <code>required int32 attrId = 1;</code>
       *
       * <pre>
       * 属性id(参考Const.attr)
       * </pre>
       */
      public Builder clearAttrId() {
        bitField0_ = (bitField0_ & ~0x00000001);
        attrId_ = 0;
        onChanged();
        return this;
      }

      // required float attrValue = 2;
      private float attrValue_ ;
      /**
       * <code>required float attrValue = 2;</code>
       *
       * <pre>
       * 属性值
       * </pre>
       */
      public boolean hasAttrValue() {
        return ((bitField0_ & 0x00000002) == 0x00000002);
      }
      /**
       * <code>required float attrValue = 2;</code>
       *
       * <pre>
       * 属性值
       * </pre>
       */
      public float getAttrValue() {
        return attrValue_;
      }
      /**
       * <code>required float attrValue = 2;</code>
       *
       * <pre>
       * 属性值
       * </pre>
       */
      public Builder setAttrValue(float value) {
        bitField0_ |= 0x00000002;
        attrValue_ = value;
        onChanged();
        return this;
      }
      /**
       * <code>required float attrValue = 2;</code>
       *
       * <pre>
       * 属性值
       * </pre>
       */
      public Builder clearAttrValue() {
        bitField0_ = (bitField0_ & ~0x00000002);
        attrValue_ = 0F;
        onChanged();
        return this;
      }

      // @@protoc_insertion_point(builder_scope:Attr)
    }

    static {
      defaultInstance = new Attr(true);
      defaultInstance.initFields();
    }

    // @@protoc_insertion_point(class_scope:Attr)
  }

  private static com.google.protobuf.Descriptors.Descriptor
    internal_static_Attr_descriptor;
  private static
    com.google.protobuf.GeneratedMessage.FieldAccessorTable
      internal_static_Attr_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\030Protocol/Attribute.proto\")\n\004Attr\022\016\n\006at" +
      "trId\030\001 \002(\005\022\021\n\tattrValue\030\002 \002(\002B\030\n\026com.haw" +
      "k.game.protocol"
    };
    com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner assigner =
      new com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner() {
        public com.google.protobuf.ExtensionRegistry assignDescriptors(
            com.google.protobuf.Descriptors.FileDescriptor root) {
          descriptor = root;
          internal_static_Attr_descriptor =
            getDescriptor().getMessageTypes().get(0);
          internal_static_Attr_fieldAccessorTable = new
            com.google.protobuf.GeneratedMessage.FieldAccessorTable(
              internal_static_Attr_descriptor,
              new java.lang.String[] { "AttrId", "AttrValue", });
          return null;
        }
      };
    com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
        }, assigner);
  }

  // @@protoc_insertion_point(outer_class_scope)
}
