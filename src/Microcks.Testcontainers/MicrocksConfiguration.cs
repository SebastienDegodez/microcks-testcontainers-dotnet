namespace Microcks.Testcontainers;

/// <inheritdoc cref="ContainerConfiguration" />
public sealed class MicrocksConfiguration : ContainerConfiguration
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MicrocksConfiguration" /> class.
	/// </summary>
	/// <param name="config">The Microcks config.</param>
	public MicrocksConfiguration(object config = null)
	{
		// // Sets the custom builder methods property values.
		// Config = config;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MicrocksConfiguration" /> class.
	/// </summary>
	/// <param name="resourceConfiguration">The Docker resource configuration.</param>
	public MicrocksConfiguration(IResourceConfiguration<CreateContainerParameters> resourceConfiguration)
		: base(resourceConfiguration)
	{
		// Passes the configuration upwards to the base implementations to create an updated immutable copy.
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MicrocksConfiguration" /> class.
	/// </summary>
	/// <param name="resourceConfiguration">The Docker resource configuration.</param>
	public MicrocksConfiguration(IContainerConfiguration resourceConfiguration)
		: base(resourceConfiguration)
	{
		// Passes the configuration upwards to the base implementations to create an updated immutable copy.
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MicrocksConfiguration" /> class.
	/// </summary>
	/// <param name="resourceConfiguration">The Docker resource configuration.</param>
	public MicrocksConfiguration(MicrocksConfiguration resourceConfiguration)
		: this(new MicrocksConfiguration(), resourceConfiguration)
	{
		// Passes the configuration upwards to the base implementations to create an updated immutable copy.
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MicrocksConfiguration" /> class.
	/// </summary>
	/// <param name="oldValue">The old Docker resource configuration.</param>
	/// <param name="newValue">The new Docker resource configuration.</param>
	public MicrocksConfiguration(MicrocksConfiguration oldValue, MicrocksConfiguration newValue)
		: base(oldValue, newValue)
	{
		// // Create an updated immutable copy of the module configuration.
		// Config = BuildConfiguration.Combine(oldValue.Config, newValue.Config);
	}

	// /// <summary>
	// /// Gets the Microcks config.
	// /// </summary>
	// public object Config { get; }
}
