﻿using System;
using Topshelf.HostConfigurators;

namespace Topshelf.Squirrel.Windows
{
	public static class RunAsExtensions
	{
        /// <summary>
        /// Runs as first prompt.
        /// </summary>
        /// <param name="configurator">The configurator.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">configurator</exception>
        public static HostConfigurator RunAsFirstPrompt(this HostConfigurator configurator)
		{
			if (configurator == null)
				throw new ArgumentNullException("configurator");

			RunAsFirstUserHostConfigurator hostConfigurator = new RunAsFirstUserHostConfigurator();
			configurator.AddConfigurator(hostConfigurator);
			return configurator;
		}
	}
}